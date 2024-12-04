# PRAMS.Configuration


## Prerequisites

### Database preparation

1. Prepare the database by running the following command in the Package Manager Console:

```bash			```

2. Update the database by running the following command in the Package Manager Console:

```bash update-database```

3. Roll back the database by running the following command in the Package Manager Console:

```bash update-database 0```
```bash Update-Database <previous-migration-name> ```
```bash Remove-Migration```

NOTE: To remove the migration use the following command in the Package Manager Console:

```bash Remove-Migration -Force -context AppPeopleDbContext```

### Configuration