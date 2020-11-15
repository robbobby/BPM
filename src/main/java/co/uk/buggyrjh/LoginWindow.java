package co.uk.buggyrjh;

import javafx.fxml.FXML;

import java.io.IOException;

public class LoginWindow {

    @FXML
    private void switchToPrimary() throws IOException {
        App.setRoot("primary");
    }
}