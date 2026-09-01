@echo off
cd /d "%~dp0"

set /p msg="Ingresa la descripcion del cambio: "
if "%msg%"=="" set msg="Actualizacion automatica"

git add .
git commit -m "%msg%"
git push origin main

echo.
echo ====================================
echo   Cambios subidos correctamente
echo ====================================
pause