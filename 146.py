def math(num=135135):

    for i in range(1,num):
        if i % 2 == 0:
            continue
        all_i = i
        for i2 in range(1,7):
            all_i = all_i * (i+2*i2)
        if all_i == num:
            return i


if __name__ == '__main__':
    print(math())

