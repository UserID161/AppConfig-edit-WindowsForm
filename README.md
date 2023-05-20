# Приложение AppConfig

![image](https://github.com/UserID161/AppConfig-edit-WindowsForm/assets/134077160/59f5880c-76a9-4332-b3e8-0fcce12b658f)
<br>
```
<connectionStrings>
		<add name="Database"
			 connectionString="Server=localhost; port=5432; user id=postgres; password=root; database=database"
			 providerName="Npgsql" />
	</connectionStrings>
```
В приложении поля изменяют параметры в connectionString:
* Поле Server - адрес сервера
* Поле Port - порт сервера
* Поле User ID - имя пользователя БД
* Поле Password - пароль пользователя БД
* Поле Databace - название БД
1.Класс Conection:
 - Для сохранения записи:
  ```
  srting Query = "SQL запрос";
  Connection connection = new Connection();
  connection.Execute(Query);
  ```
 - Для отображения данных:
  ```
  string Query = "SELECT * FROM public.users";
  var reader = new Connection().Select(Query);
  dataGridView1.Rows.Clear();
  while(reader.Read())
  	{
 		dataGridView1.Rows.Add(reader["id"], reader["user_name"];
 	}
 ```


