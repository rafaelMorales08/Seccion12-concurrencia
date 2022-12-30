using System.Diagnostics;

namespace concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            var sw = new Stopwatch();

            sw.Start();
            //await RealizarProcesaminetoLargoA();
            //await RealizarProcesaminetoLargoB();
            //await RealizarProcesaminetoLargoC();

             var tareas = new List<Task>();
            {
                //await RealizarProcesaminetoLargoA();
                //await RealizarProcesaminetoLargoB();
                //await RealizarProcesaminetoLargoC();


            };

            await Task.WhenAll(tareas);

            sw.Stop();

            var duracion = ($"EL programa se ejecuto en {sw.ElapsedMilliseconds / 1000.0} segundos");
            Console.WriteLine( duracion );


            //await Task.Delay(5000);
            //await RealizarProcesaminetoLargo();
            // var  nombre = await  ObtenerNombre();
            //MessageBox.Show($"hola {nombre}");

            //proceso lento 

           
            pictureBox1.Visible = false;
        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.EnumerateDirectories( directorio );
        }
        private List<Imagen> ObtenerImagenes()
        {
            var imagenes = new List<Imagen>();

            for (int i = 0; i < 7; i++)
            {
                imagenes.Add(new Imagen()
                {
                    Nombre = $"CABEZAoLMEca {i}.jpg",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/d/db/Olmec_Head_No._1.jpg"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"Cerro {i}.jpg",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/9/98/15-07-13_Teotihuacan_la_Avenida_de_los_Muertos_y_la_Pir%C3%A1mide_del_Sol-RalfR-WMA_0251.jpg"
                });


                imagenes.Add(new Imagen()
                {
                    Nombre = $"maya {i}.jpg",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Tlaloc%2C_God_of_the_Rain%2C_Thunder%2C_Earthquakes%3B_Codex_Borgia.jpg/220px-Tlaloc%2C_God_of_the_Rain%2C_Thunder%2C_Earthquakes%3B_Codex_Borgia.jpg"
                });


            }

            return imagenes;
        }




        //private async Task RealizarProcesaminetoLargoA()
        //{
        //    await Task.Delay(500);
        //    Console.WriteLine("proceso ha A  finalizado");
        //}

        //private async Task RealizarProcesaminetoLargoB()
        //{
        //    await Task.Delay(500);
        //    Console.WriteLine("proceso ha B finalizado");
        //}

        //private async Task RealizarProcesaminetoLargoC()
        //{
        //    await Task.Delay(500);
        //    Console.WriteLine("proceso ha C finalizado");
        //}



        //private async Task<string> ObtenerNombre()
        //{
        //    await Task.Delay(100);
        //    return "rafael";
        //}
    }
}