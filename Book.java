public class Book {

    private String title;
    private String author;
    private String chapter;
    private String subchapter;
    private int image;
    private int paragraph;
    private int table;


    public Book(String title, String author, String chapter, String subchapter, int image, int paragraph, int table) {
        this.title = title;
        this.author = author;
        this.chapter = chapter;
        this.subchapter = subchapter;
        this.image = image;
        this.paragraph = paragraph;
        this.table = table;
    }

    public Book(Book book) {
        this.title = book.title;
        this.author = book.author;
        this.chapter = book.chapter;
        this.subchapter = book.subchapter;
        this.image = book.image;
        this.paragraph = book.paragraph;
        this.table = book.table;
    }

    public String getTitle() {
        return title;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String toString() {
        return String.format("%-10s %s\n", "Title:", title) +
            String.format("%-10s %s\n", "Author:", author) +
            String.format("%-10s %d\n", "Chapter:", chapter) +
            String.format("%-10s %s\n", "Subchapter:", subchapter) +
            String.format("%-10s %s\n", "Image:", image) +
             String.format("%-10s %s\n", "Paragraph:", paragraph) +
            String.format("%-10s %d", "Table:", Table);
    }

}





public class Main {

    public static void main(String[] args) {
        Book first = new Book("The Book", "Famous Writer", 199, "Big Book Publisher", 1984);
        Book second = new Book("The Second Book", "Less F. Writer", 249, "The Book Publishers", 1999);

        System.out.println("First book");
        System.out.println(first + "\n");
        System.out.println("Second book");
        System.out.println(second + "\n");

        System.out.println("Title of the first book: " + first.getTitle() + "\n");


        Book firstCopy = new Book(first);
        System.out.println("Copy of the first book:");
        System.out.println(firstCopy + "\n");

        System.out.println("Copy equals first book: " + firstCopy.equals(first));
        System.out.println("Second book equals first book: " + second.equals(first));
        System.out.println();

        System.out.println("Change writer of the copy to :'Most F. Writer'");
        firstCopy.setAuthor("Most F. Writer");
        System.out.println(firstCopy + "\n");
        System.out.println("Copy equals first book: " + firstCopy.equals(first));

    }

}
