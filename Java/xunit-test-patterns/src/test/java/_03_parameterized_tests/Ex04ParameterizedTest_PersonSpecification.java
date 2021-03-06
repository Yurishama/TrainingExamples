package _03_parameterized_tests;

import lombok.val;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class Ex04ParameterizedTest_PersonSpecification {

    @DataProvider
    public static Object[][] shouldBeAdultDependingOnAgeData() {
        return new Object[][]{
            {17, false},
            {18, true},
        };
    }

    @Test(dataProvider = "shouldBeAdultDependingOnAgeData")
    public void shouldBeAdultDependingOnAge(int age, boolean expectedIsAdult) {
        //GIVEN
        val person = new Person(age);

        //WHEN
        val isAdult = person.isAdult();

        //THEN
        assertThat(isAdult).isEqualTo(expectedIsAdult);
    }

}
