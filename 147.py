
def math(num=3571):
    str_num = str(num)
    List = ''
    for i in range(1,len(str_num)+1):
        List += str(str_num[-1*i])

    List = int(List)
    c = num - List
    if c < 0:
        c *= -1
    print("数字：%d，反转值：%d, 绝对差值: %d",(num,List,c))




if __name__ == '__main__':
    math()