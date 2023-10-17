namespace Session5
{
    internal class Book
    {
        //tạo các trường dữ liệu
        private int id;
        private string title;
        private int price;
        private string publisher;

        //tạo constructor có và không có tham số để khởi tạo cho các trường tương ứng
        public Book()
        {
            id = 0;
            title = string.Empty;
            price = 0;
            publisher = string.Empty;
        }

        public Book(int id, string title, int price, string publisher)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.publisher = publisher;
        }

        //tạo thuộc tính cho trường Id và Title (ReadOnly)
        //Thuộc tính accessor có thể khai báo thiếu set hoặc get, nếu thiếu set nó trở thành loại chỉ đọc (readonly).
        public int Id { get { return id; } }
        public string Title { get { return title; } }


        //Tạo thuộc tính price, publisher (read, write)
        public int Price { get { return price; } set { price = value; } }
        public string Publisher { get {  return publisher; } set {  publisher = value; } }


        //Ghi đè phương thức ToString() để trả về toàn bộ thông tin về Book
        public override string ToString()
        {
            return ($"Id: {Id}\nTitle: {Title}\nPrice: {Price}\nPublisher: {Publisher}\n");
        }









    }
}
