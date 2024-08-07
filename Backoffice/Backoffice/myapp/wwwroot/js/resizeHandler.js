window.resizeHandler = {
    checkScreenSize: function (dotnetHelper) {
        const checkScreenSize = () => {
            if (window.innerWidth >= 992) {
                dotnetHelper.invokeMethodAsync('CheckScreenSize', window.innerWidth);
            }
        };

        window.addEventListener('resize', checkScreenSize);

        checkScreenSize();
    }
};
