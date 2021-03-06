﻿using System;
using System.Collections.Generic;
using System.Linq;
using TestInterface;
using Microsoft.Office.Interop.PowerPoint;
using PowerPointLabs.ActionFramework.Common.Extension;

namespace PowerPointLabs.FunctionalTestInterface.Impl.Controller
{
    [Serializable]
    class ShapesLabController : MarshalByRefObject, IShapesLabController
    {
        private static IShapesLabController _instance = new ShapesLabController();

        public static IShapesLabController Instance { get { return _instance; } }

        private CustomShapePane _pane;

        private ShapesLabController() {}

        public void OpenPane()
        {
            UIThreadExecutor.Execute(() =>
            {
                FunctionalTestExtensions.GetRibbonUi().CustomShapeButtonClick(
                    new RibbonControl("ShapesLab"));
                _pane = FunctionalTestExtensions.GetTaskPane(
                    typeof(CustomShapePane)).Control as CustomShapePane;
            });
        }

        public void SaveSelectedShapes()
        {
            UIThreadExecutor.Execute(() =>
            {
                FunctionalTestExtensions.GetRibbonUi().AddShapeButtonClick(
                    new RibbonControl("AddShapeToShapesLab"));
            });
        }

        public IShapesLabLabeledThumbnail GetLabeledThumbnail(string labelName)
        {
            if (_pane != null)
            {
                return _pane.GetLabeledThumbnail(labelName);
            }
            return null;
        }

        public void ImportLibrary(string pathToLibrary)
        {
            if (_pane != null)
            {
                _pane.ImportLibrary(pathToLibrary);
            }
        }

        public void ImportShape(string pathToShape)
        {
            if (_pane != null)
            {
                _pane.ImportShape(pathToShape);
            }
        }

        public List<ISlideData> FetchShapeGalleryPresentationData()
        {
            if (_pane != null)
            {
                var slideData = _pane.GetShapeGallery()
                    .Slides.Cast<Slide>().Select(SlideData.FromSlide).ToList();
                return slideData;
            }
            return null;
        }
    }
}
