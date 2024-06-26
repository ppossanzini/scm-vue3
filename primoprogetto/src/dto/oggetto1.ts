class Oggetto1 {
  id: number;
  descrizione: string;
  quantita: number;
  prezzo: number;


  vv: number = 0;

  constructor(id: number, descrizione: string, quantita: number, prezzo: number) {
    this.id = id;
    this.descrizione = descrizione;
    this.quantita = quantita;
    this.prezzo = prezzo;
  }

  get Id(): number {
    return this.id;
  }
  set Id(id: number) {
    this.id = id;
  }

  getDescrizione = () => descrizione;

  public getPrezzo(): number {
    return this.prezzo;
  }
}