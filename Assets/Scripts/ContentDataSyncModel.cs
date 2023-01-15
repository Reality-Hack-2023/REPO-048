using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using Normal.Realtime.Serialization;

[RealtimeModel]
public partial class ContentDataSyncModel {
    [RealtimeProperty(1, true, true)]
    private int _contentType;
    [RealtimeProperty(2, true, true)]
    private int _contentId;
    [RealtimeProperty(3, false, true)]
    private float _translationOffset;
    [RealtimeProperty(4, false, true)]
    private float _rotationOffset;
    [RealtimeProperty(5, false, true)]
    private float _sizeOffset;
    [RealtimeProperty(6, true, true)]
    private bool _isManipulating;
    [RealtimeProperty(7, true, true)]
    private int _manipulateMode; //0, 1, or 2 (move, rotate, resize)
    [RealtimeProperty(8, true, true)]
    private int _remoteImageNum = -1; //if >= 0, then we are an image type that is on the remote server (i.e a drawing)
}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class ContentDataSyncModel : RealtimeModel {
    public float translationOffset {
        get {
            return _translationOffsetProperty.value;
        }
        set {
            if (_translationOffsetProperty.value == value) return;
            _translationOffsetProperty.value = value;
            InvalidateUnreliableLength();
            FireTranslationOffsetDidChange(value);
        }
    }
    
    public float rotationOffset {
        get {
            return _rotationOffsetProperty.value;
        }
        set {
            if (_rotationOffsetProperty.value == value) return;
            _rotationOffsetProperty.value = value;
            InvalidateUnreliableLength();
            FireRotationOffsetDidChange(value);
        }
    }
    
    public float sizeOffset {
        get {
            return _sizeOffsetProperty.value;
        }
        set {
            if (_sizeOffsetProperty.value == value) return;
            _sizeOffsetProperty.value = value;
            InvalidateUnreliableLength();
            FireSizeOffsetDidChange(value);
        }
    }
    
    public int contentType {
        get {
            return _contentTypeProperty.value;
        }
        set {
            if (_contentTypeProperty.value == value) return;
            _contentTypeProperty.value = value;
            InvalidateReliableLength();
            FireContentTypeDidChange(value);
        }
    }
    
    public int contentId {
        get {
            return _contentIdProperty.value;
        }
        set {
            if (_contentIdProperty.value == value) return;
            _contentIdProperty.value = value;
            InvalidateReliableLength();
            FireContentIdDidChange(value);
        }
    }
    
    public bool isManipulating {
        get {
            return _isManipulatingProperty.value;
        }
        set {
            if (_isManipulatingProperty.value == value) return;
            _isManipulatingProperty.value = value;
            InvalidateReliableLength();
            FireIsManipulatingDidChange(value);
        }
    }
    
    public int manipulateMode {
        get {
            return _manipulateModeProperty.value;
        }
        set {
            if (_manipulateModeProperty.value == value) return;
            _manipulateModeProperty.value = value;
            InvalidateReliableLength();
            FireManipulateModeDidChange(value);
        }
    }
    
    public int remoteImageNum {
        get {
            return _remoteImageNumProperty.value;
        }
        set {
            if (_remoteImageNumProperty.value == value) return;
            _remoteImageNumProperty.value = value;
            InvalidateReliableLength();
            FireRemoteImageNumDidChange(value);
        }
    }
    
    public delegate void PropertyChangedHandler<in T>(ContentDataSyncModel model, T value);
    public event PropertyChangedHandler<int> contentTypeDidChange;
    public event PropertyChangedHandler<int> contentIdDidChange;
    public event PropertyChangedHandler<float> translationOffsetDidChange;
    public event PropertyChangedHandler<float> rotationOffsetDidChange;
    public event PropertyChangedHandler<float> sizeOffsetDidChange;
    public event PropertyChangedHandler<bool> isManipulatingDidChange;
    public event PropertyChangedHandler<int> manipulateModeDidChange;
    public event PropertyChangedHandler<int> remoteImageNumDidChange;
    
    public enum PropertyID : uint {
        ContentType = 1,
        ContentId = 2,
        TranslationOffset = 3,
        RotationOffset = 4,
        SizeOffset = 5,
        IsManipulating = 6,
        ManipulateMode = 7,
        RemoteImageNum = 8,
    }
    
    #region Properties
    
    private ReliableProperty<int> _contentTypeProperty;
    
    private ReliableProperty<int> _contentIdProperty;
    
    private UnreliableProperty<float> _translationOffsetProperty;
    
    private UnreliableProperty<float> _rotationOffsetProperty;
    
    private UnreliableProperty<float> _sizeOffsetProperty;
    
    private ReliableProperty<bool> _isManipulatingProperty;
    
    private ReliableProperty<int> _manipulateModeProperty;
    
    private ReliableProperty<int> _remoteImageNumProperty;
    
    #endregion
    
    public ContentDataSyncModel() : base(null) {
        _contentTypeProperty = new ReliableProperty<int>(1, _contentType);
        _contentIdProperty = new ReliableProperty<int>(2, _contentId);
        _translationOffsetProperty = new UnreliableProperty<float>(3, _translationOffset);
        _rotationOffsetProperty = new UnreliableProperty<float>(4, _rotationOffset);
        _sizeOffsetProperty = new UnreliableProperty<float>(5, _sizeOffset);
        _isManipulatingProperty = new ReliableProperty<bool>(6, _isManipulating);
        _manipulateModeProperty = new ReliableProperty<int>(7, _manipulateMode);
        _remoteImageNumProperty = new ReliableProperty<int>(8, _remoteImageNum);
    }
    
    protected override void OnParentReplaced(RealtimeModel previousParent, RealtimeModel currentParent) {
        _contentTypeProperty.UnsubscribeCallback();
        _contentIdProperty.UnsubscribeCallback();
        _isManipulatingProperty.UnsubscribeCallback();
        _manipulateModeProperty.UnsubscribeCallback();
        _remoteImageNumProperty.UnsubscribeCallback();
    }
    
    private void FireContentTypeDidChange(int value) {
        try {
            contentTypeDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireContentIdDidChange(int value) {
        try {
            contentIdDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireTranslationOffsetDidChange(float value) {
        try {
            translationOffsetDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireRotationOffsetDidChange(float value) {
        try {
            rotationOffsetDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireSizeOffsetDidChange(float value) {
        try {
            sizeOffsetDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireIsManipulatingDidChange(bool value) {
        try {
            isManipulatingDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireManipulateModeDidChange(int value) {
        try {
            manipulateModeDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireRemoteImageNumDidChange(int value) {
        try {
            remoteImageNumDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    protected override int WriteLength(StreamContext context) {
        var length = 0;
        length += _contentTypeProperty.WriteLength(context);
        length += _contentIdProperty.WriteLength(context);
        length += _translationOffsetProperty.WriteLength(context);
        length += _rotationOffsetProperty.WriteLength(context);
        length += _sizeOffsetProperty.WriteLength(context);
        length += _isManipulatingProperty.WriteLength(context);
        length += _manipulateModeProperty.WriteLength(context);
        length += _remoteImageNumProperty.WriteLength(context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        var writes = false;
        writes |= _contentTypeProperty.Write(stream, context);
        writes |= _contentIdProperty.Write(stream, context);
        writes |= _translationOffsetProperty.Write(stream, context);
        writes |= _rotationOffsetProperty.Write(stream, context);
        writes |= _sizeOffsetProperty.Write(stream, context);
        writes |= _isManipulatingProperty.Write(stream, context);
        writes |= _manipulateModeProperty.Write(stream, context);
        writes |= _remoteImageNumProperty.Write(stream, context);
        if (writes) InvalidateContextLength(context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        var anyPropertiesChanged = false;
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            var changed = false;
            switch (propertyID) {
                case (uint) PropertyID.ContentType: {
                    changed = _contentTypeProperty.Read(stream, context);
                    if (changed) FireContentTypeDidChange(contentType);
                    break;
                }
                case (uint) PropertyID.ContentId: {
                    changed = _contentIdProperty.Read(stream, context);
                    if (changed) FireContentIdDidChange(contentId);
                    break;
                }
                case (uint) PropertyID.TranslationOffset: {
                    changed = _translationOffsetProperty.Read(stream, context);
                    if (changed) FireTranslationOffsetDidChange(translationOffset);
                    break;
                }
                case (uint) PropertyID.RotationOffset: {
                    changed = _rotationOffsetProperty.Read(stream, context);
                    if (changed) FireRotationOffsetDidChange(rotationOffset);
                    break;
                }
                case (uint) PropertyID.SizeOffset: {
                    changed = _sizeOffsetProperty.Read(stream, context);
                    if (changed) FireSizeOffsetDidChange(sizeOffset);
                    break;
                }
                case (uint) PropertyID.IsManipulating: {
                    changed = _isManipulatingProperty.Read(stream, context);
                    if (changed) FireIsManipulatingDidChange(isManipulating);
                    break;
                }
                case (uint) PropertyID.ManipulateMode: {
                    changed = _manipulateModeProperty.Read(stream, context);
                    if (changed) FireManipulateModeDidChange(manipulateMode);
                    break;
                }
                case (uint) PropertyID.RemoteImageNum: {
                    changed = _remoteImageNumProperty.Read(stream, context);
                    if (changed) FireRemoteImageNumDidChange(remoteImageNum);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
            anyPropertiesChanged |= changed;
        }
        if (anyPropertiesChanged) {
            UpdateBackingFields();
        }
    }
    
    private void UpdateBackingFields() {
        _contentType = contentType;
        _contentId = contentId;
        _translationOffset = translationOffset;
        _rotationOffset = rotationOffset;
        _sizeOffset = sizeOffset;
        _isManipulating = isManipulating;
        _manipulateMode = manipulateMode;
        _remoteImageNum = remoteImageNum;
    }
    
}
/* ----- End Normal Autogenerated Code ----- */