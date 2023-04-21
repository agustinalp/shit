@@ -411,8 +411,7 @@ clone_faceswap() {
setup_faceswap() {
    # Run faceswap setup script
    info "Setting up Faceswap..."
    if [ $VERSION != "cpu" ] ; then args="--$VERSION" ; else args="" ; fi
    python -u "$DIR_FACESWAP/setup.py" --installer $args
    python -u "$DIR_FACESWAP/setup.py" --installer --$VERSION
}

create_gui_launcher () {
