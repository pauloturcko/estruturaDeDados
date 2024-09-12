using ListaGenerica;

List<Books> Bk = new List<Books>();
Books book1 = new Books(){
    Title = "Aprendendo Laravel: o Framework PHP dos Artesãos da web",
    Author = "Michael Douglas e Matheus Marabesi",
    Publisher = "Novatec Editora",
    PageNumber = 304,
    Gender = GenderEnum.Estudo,
};
Books book2 = new Books(){
    Title = "Aprendendo Node: Usando JavaScript no Servidor",
    Author = "Shelley Powers",
    Publisher = "Novatec Editora",
    PageNumber = 312,
    Gender = GenderEnum.Estudo,
};
Books book3 = new Books(){
    Title = "Mitologia Nórdica",
    Author = "Neil Gaiman",
    Publisher = "Intrísica",
    PageNumber = 288,
    Gender = GenderEnum.Aventura,
};
Books book4 = new Books(){
    Title = "The Witcher - Box Capa Dura",
    Author = "Andrzej Sapkowski",
    Publisher = "WMF Martins Fontes",
    PageNumber = 3140,
    Gender = GenderEnum.Aventura,
};
Books book5 = new Books(){
    Title = "STAR WARS: DARK EDITION: Edição épica para uma saga eterna!",
    Author = "George Lucas",
    Publisher = "Darkside",
    PageNumber = 528,
    Gender = GenderEnum.Ação,
};
Books book6 = new Books(){
    Title = "Sexta Feira 13 - Arquivos de Crystal Lake - Bloody Edition",
    Author = "David Grove",
    Publisher = "Darkside",
    PageNumber = 320,
    Gender = GenderEnum.Terror
};

List<Books> tempBooks = new List<Books> { book1, book2, book3, book4, book5, book6 };
tempBooks.ForEach(book => Bk.Add(book));

foreach(Books b in Bk) {
    Console.WriteLine(b.Title);
};