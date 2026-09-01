@echo off
cd /d "%~dp0"

echo Descargando cambios de GitHub...

git fetch origin
git pull origin main

echo.
echo ====================================
echo   Proyecto actualizado
echo ====================================
pause