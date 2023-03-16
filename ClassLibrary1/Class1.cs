namespace ClassLibrary1 {
    public class Pessoa {
        public string name;
        public string cpf;
        public DateTime nas;

        public bool valCPF(string cpf) {
            if(cpf.Count() == 11) { 
               return true;
            }else { 
               return false;
            }
        }

        public string setName(string name) {
            this.name = name;
            return name;
        }

        public int age(DateTime nas) {
            int age = DateTime.Now.Year - nas.Year;
            return age;
        }
    }
}