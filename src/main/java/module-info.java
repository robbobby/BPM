module co.uk.buggyrjh {
    requires javafx.controls;
    requires javafx.fxml;

    opens co.uk.buggyrjh to javafx.fxml;
    exports co.uk.buggyrjh;
}