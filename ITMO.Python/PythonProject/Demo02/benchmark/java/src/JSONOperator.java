import Dto.InputData;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.JavaType;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.*;

public class JSONOperator<T> {
    private String inputPath;
    private Class<T> cls;

    public JSONOperator(String inputPath, Class<T> cls) {
        this.inputPath = inputPath;
        this.cls = cls;
    }

    public InputData<T> readJSON() throws JsonProcessingException, NullPointerException {
        String jsonText = readFromFile();
        if (jsonText == null) {
            throw new NullPointerException("[Java] Ошибка чтения входного файла");
        }

        ObjectMapper mapper = new ObjectMapper();
        JavaType type = mapper.getTypeFactory().constructParametricType(InputData.class, cls);
        InputData<T> inputData = mapper.readValue(jsonText, type);
        return inputData;
    }

    private String readFromFile() {
        String line = "";
        try (BufferedReader reader = new BufferedReader(
                new FileReader(this.inputPath))) {
            line = reader.readLine();
        } catch (IOException ex) {
            System.err.println("[Java] Error: " + ex.getMessage());
            line = null;
        }

        return line;
    }
}
