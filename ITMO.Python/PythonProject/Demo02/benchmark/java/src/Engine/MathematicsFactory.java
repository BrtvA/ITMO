package Engine;

import java.math.BigInteger;

public class MathematicsFactory<T> {
    private Class<T> cls;

    public MathematicsFactory(Class<T> cls) {
        this.cls = cls;
    }

    public IMathematics<T> get() throws IllegalStateException {
        IMathematics<T> IMathematics;
        if (cls.equals(Integer.class)) {
            IMathematics = (IMathematics<T>) new IntMathematics();
        } else if (cls.equals(Double.class)) {
            IMathematics = (IMathematics<T>) new DoubleMathematics();
        } else if (cls.equals(BigInteger.class)) {
            IMathematics = (IMathematics<T>) new BigIntMathematics();
        } else {
            throw new IllegalStateException("[Java] Неожиданное значение для типа данных: " + cls);
        }

        return IMathematics;
    }
}
