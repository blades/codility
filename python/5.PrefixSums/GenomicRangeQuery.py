def solution(S, P, Q):  
    count_a = [0] * (len(S) + 1)
    count_c = [0] * (len(S) + 1)
    count_g = [0] * (len(S) + 1)
    count_t = [0] * (len(S) + 1)

    counter = 1;
    for char in S:
        if char == 'A':
            count_a[counter] += 1;
        if char == 'C':
            count_c[counter] += 1;
        if char == 'G':
            count_g[counter] += 1;
        if char == 'T':
            count_t[counter] += 1;
        if counter > 0:
            count_a[counter] += count_a[counter -1]
            count_c[counter] += count_c[counter -1]
            count_g[counter] += count_g[counter -1]
            count_t[counter] += count_t[counter -1]
        counter+=1
    output = [0] * len(P)
    for i in range(len(P)):
        start = P[i]
        end = Q[i] + 1
        a_diff = count_a[end] - count_a[start]
        c_diff = count_c[end] - count_c[start]
        g_diff = count_g[end] - count_g[start]
        t_diff = count_t[end] - count_t[start]
        if a_diff > 0:
            output[i] = 1
        elif c_diff > 0:
            output[i] = 2
        elif g_diff > 0:
            output[i] = 3
        elif t_diff > 0:
            output[i] = 4
    return output
