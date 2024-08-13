export function calculateAge(fechaNacimientoId, edadId) {
    const fechaNacimiento = document.getElementById(fechaNacimientoId).value;
    const hoy = new Date();
    const nacimiento = new Date(fechaNacimiento);

    let edad = hoy.getFullYear() - nacimiento.getFullYear();
    const mes = hoy.getMonth() - nacimiento.getMonth();
    if (mes < 0 || (mes === 0 && hoy.getDate() < nacimiento.getDate())) {
        edad--;
    }

    document.getElementById(edadId).innerText = edad;
}