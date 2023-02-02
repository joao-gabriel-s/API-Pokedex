using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokedexForms
{
    public partial class Form1 : Form
    {
        int numeroPokemon = 1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = GetImage(numeroPokemon);
            label1.Text = "Nome: bulbasaur";
            Peso.Text = "Peso: 6,9 Kg";
        }

        public Image GetImage(int id)
        {
            var pergarImagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + id + ".png";

            var request = WebRequest.Create(pergarImagem);

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    return Image.FromStream(stream);

                }
            }
        }

        public async Task<Stat> GetStats(string nome)
        {
            try
            {
                var stats = new List<Stat>();
                HttpClient cliente = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/" + nome) };
                var resposta = cliente.GetAsync(nome).Result;
                var conteudo = await resposta.Content.ReadAsStringAsync();
                var stat = JsonConvert.DeserializeObject<Stat>(conteudo);

                stats.Add(stat);

                return stat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Pokemon> PokemonNome(int id)
        {
            try
            {
                HttpClient cliente = new HttpClient();

                var resposta = await cliente.GetAsync("https://pokeapi.co/api/v2/pokemon/" + id);

                var conteudo = await resposta.Content.ReadAsStringAsync();

                var pokemonConteudo = JsonConvert.DeserializeObject<Pokemon>(conteudo);

                if (pokemonConteudo.PokemonName == null)
                {
                    return null;
                }


                Pokemon pokemon = new Pokemon(pokemonConteudo.PokemonName, pokemonConteudo.Species, pokemonConteudo.Stats, pokemonConteudo.Link);
                pokemon.Stats.Add(await GetStats(pokemon.PokemonName));
                return pokemon;


            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e) //avançar
        {
            numeroPokemon = numeroPokemon + 1;
            var imagem = GetImage(numeroPokemon);
            pictureBox1.Image = imagem;


            Pokemon pokemon = new Pokemon();
            pokemon = await PokemonNome(numeroPokemon);   
            
            label1.Text = "Nome: " + pokemon.PokemonName;


            pokemon.Stats[6].weight.Replace(",", "");

            if (pokemon.Stats[6].weight.Length == 2)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(1, ",");
            }

            else if (pokemon.Stats[6].weight.Length == 3)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(2, ",");
            }

            else if (pokemon.Stats[6].weight.Length == 4)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(3, ",");
            }

            Peso.Text = "Peso: " + pokemon.Stats[6].weight + " Kg";
            HP.Text = "HP: " + Convert.ToString(pokemon.Stats[0].BaseStat);
            Attack.Text = "Ataque: " + Convert.ToString(pokemon.Stats[1].BaseStat);
            Defense.Text = "Defesa: " + Convert.ToString(pokemon.Stats[2].BaseStat);
            SpecialA.Text = "Ataque especial: " + Convert.ToString(pokemon.Stats[3].BaseStat);
            SpecialD.Text = "Defesa especial: " + Convert.ToString(pokemon.Stats[3].BaseStat);
            Speed.Text = "Velocidade: " + Convert.ToString(pokemon.Stats[4].BaseStat);
        }

        private async void pictureBox3_Click(object sender, EventArgs e) //voltar
        {
            numeroPokemon = numeroPokemon - 1;

            if (numeroPokemon == 0)
                numeroPokemon = 1;

            var imagem = GetImage(numeroPokemon);
            pictureBox1.Image = imagem;

            Pokemon pokemon = new Pokemon();
            pokemon = await PokemonNome(numeroPokemon);
            label1.Text = "Nome: " + pokemon.PokemonName;

            pokemon.Stats[6].weight.Replace(",", "");

            if (pokemon.Stats[6].weight.Length == 2)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(1, ",");
            }

            else if (pokemon.Stats[6].weight.Length == 3)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(2, ",");
            }

            else if (pokemon.Stats[6].weight.Length == 4)
            {
                pokemon.Stats[6].weight = pokemon.Stats[6].weight.Insert(3, ",");
            }

            Peso.Text = "Peso: " + pokemon.Stats[6].weight + " Kg";
            HP.Text = "HP: " + Convert.ToString(pokemon.Stats[0].BaseStat);
        }
    }
}