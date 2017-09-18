C21.Koo.RouteApp

### 0.整理链家列表页规则
http://xxx.com/{zufang||ershoufang}/{行政区拼音||行政区拼音-商圈拼音}
http://xxx.com/{ditiefang||ditiezufang}/li{地铁编号}s{站点编号}
li:地铁编号
s:站点编号



条件 + 关键词
仅关键词
仅条件
无任何条件


http://xxx.com/zufang/chaoyang-guomao/s1s2s3a1s2s3bs50000es90000pg1rs张三
route:zufang/{district}-{tradingarea}/{condition}rs{keyword}

http://xxx.com/zufang/chaoyang-guomao/rs张三
route:zufang/{district}-{tradingarea}/rs{keyword}

http://xxx.com/zufang/chaoyang-guomao/s1s2s3a1s2s3bs50000es90000pg1
route:/zufang/{district}-{tradingarea}/{condition}

http://xxx.com/zufang/chaoyang-guomao/
route:zufang/{district}-{tradingarea}/

http://localhost:36552/zufang/chaoyang/s1s2s3bs500es9999pg1rs张三
route:zufang/{district}/{condition}rs{keyword}

http://localhost:36552/zufang/chaoyang/rs张三
route:zufang/{district}/rs{keyword}

http://localhost:36552/zufang/chaoyang/s1s2s3bs500es9999pg1a1a2
route:zufang/{district}/{condition}

http://localhost:36552/zufang/a1a2a3s1s2s3bs500es900ba500ea5000pg1rs张三
route:zufang/{condition}rs{keyword}

http://localhost:36552/zufang/rs张三
route:zufang/rs{keyword}

http://localhost:36552/zufang/a1a2a3s1s2s3bs500es900ba500ea5000pg1
route:zufang/{condition}/

http://localhost:36552/zufang/chaoyang/
route:zufang/{district}/

http://xxx.com/zufang/  
301 Redirect: /zufang/pg1



/p{1}p{N}a{1}a{N}l{1}l{N}t{1}t{N}y{N}sf{N}lc{N}f{N}de{N}bp{number}ep{number}ba{number}ea{number}co{tabIndex|sort_direction}pg{pageIndex}rs{keyword}/
p:价格
a:面积
l:房型
t:标签
y:楼龄
sf:房屋类型
lc:楼层
f:朝向
de:装修
bp:最低价格
ep:最高价格
ba:最小面积
ea:最大面积
co:选项卡和排序方向[1.最新房源，2.房源租金，3.房源面积，4.临近地铁]
pg:分页
keyword:搜索关键词

### 1.目录
/ershoufang/

### 2.分页参数
pg1,pg2,pg3

### 3.js和css路径
都用绝对路径

### 4.左侧工具栏
不静态化

### 5.绑定模板(列表+分页)

### 6.查询列表数据

### 7.列表选项卡和排序
默认排序：""
最新房源、最新发布：P1
房屋总价 (P2: ASC, P3: DESC)
房屋单价 (P4: ASC, P5: DESC)
房源面积 (P6: ASC, P7: DESC)
房源租金 (P8: ASC, P9: DESC)
热门房源：PA
临近地铁：PB
