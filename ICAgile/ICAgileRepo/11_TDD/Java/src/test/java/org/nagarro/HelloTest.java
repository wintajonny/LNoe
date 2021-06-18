package org.nagarro;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class HelloTest {

    @Test
    public void shouldGreet() {
        Hello hello = new Hello();

        String greeting = hello.greeting();

        assertThat("Hello World").isEqualTo(greeting);
    }

}
