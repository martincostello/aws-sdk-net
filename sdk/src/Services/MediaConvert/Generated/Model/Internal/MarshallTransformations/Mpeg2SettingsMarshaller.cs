/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Mpeg2Settings Marshaller
    /// </summary>
    public class Mpeg2SettingsMarshaller : IRequestMarshaller<Mpeg2Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Mpeg2Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("adaptiveQuantization");
                context.Writer.WriteStringValue(requestObject.AdaptiveQuantization);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetCodecLevel())
            {
                context.Writer.WritePropertyName("codecLevel");
                context.Writer.WriteStringValue(requestObject.CodecLevel);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.WriteStringValue(requestObject.CodecProfile);
            }

            if(requestObject.IsSetDynamicSubGop())
            {
                context.Writer.WritePropertyName("dynamicSubGop");
                context.Writer.WriteStringValue(requestObject.DynamicSubGop);
            }

            if(requestObject.IsSetFramerateControl())
            {
                context.Writer.WritePropertyName("framerateControl");
                context.Writer.WriteStringValue(requestObject.FramerateControl);
            }

            if(requestObject.IsSetFramerateConversionAlgorithm())
            {
                context.Writer.WritePropertyName("framerateConversionAlgorithm");
                context.Writer.WriteStringValue(requestObject.FramerateConversionAlgorithm);
            }

            if(requestObject.IsSetFramerateDenominator())
            {
                context.Writer.WritePropertyName("framerateDenominator");
                context.Writer.WriteNumberValue(requestObject.FramerateDenominator.Value);
            }

            if(requestObject.IsSetFramerateNumerator())
            {
                context.Writer.WritePropertyName("framerateNumerator");
                context.Writer.WriteNumberValue(requestObject.FramerateNumerator.Value);
            }

            if(requestObject.IsSetGopClosedCadence())
            {
                context.Writer.WritePropertyName("gopClosedCadence");
                context.Writer.WriteNumberValue(requestObject.GopClosedCadence.Value);
            }

            if(requestObject.IsSetGopSize())
            {
                context.Writer.WritePropertyName("gopSize");
                if(StringUtils.IsSpecialDoubleValue(requestObject.GopSize.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.GopSize.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.GopSize.Value);
                }
            }

            if(requestObject.IsSetGopSizeUnits())
            {
                context.Writer.WritePropertyName("gopSizeUnits");
                context.Writer.WriteStringValue(requestObject.GopSizeUnits);
            }

            if(requestObject.IsSetHrdBufferFinalFillPercentage())
            {
                context.Writer.WritePropertyName("hrdBufferFinalFillPercentage");
                context.Writer.WriteNumberValue(requestObject.HrdBufferFinalFillPercentage.Value);
            }

            if(requestObject.IsSetHrdBufferInitialFillPercentage())
            {
                context.Writer.WritePropertyName("hrdBufferInitialFillPercentage");
                context.Writer.WriteNumberValue(requestObject.HrdBufferInitialFillPercentage.Value);
            }

            if(requestObject.IsSetHrdBufferSize())
            {
                context.Writer.WritePropertyName("hrdBufferSize");
                context.Writer.WriteNumberValue(requestObject.HrdBufferSize.Value);
            }

            if(requestObject.IsSetInterlaceMode())
            {
                context.Writer.WritePropertyName("interlaceMode");
                context.Writer.WriteStringValue(requestObject.InterlaceMode);
            }

            if(requestObject.IsSetIntraDcPrecision())
            {
                context.Writer.WritePropertyName("intraDcPrecision");
                context.Writer.WriteStringValue(requestObject.IntraDcPrecision);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.WriteNumberValue(requestObject.MaxBitrate.Value);
            }

            if(requestObject.IsSetMinIInterval())
            {
                context.Writer.WritePropertyName("minIInterval");
                context.Writer.WriteNumberValue(requestObject.MinIInterval.Value);
            }

            if(requestObject.IsSetNumberBFramesBetweenReferenceFrames())
            {
                context.Writer.WritePropertyName("numberBFramesBetweenReferenceFrames");
                context.Writer.WriteNumberValue(requestObject.NumberBFramesBetweenReferenceFrames.Value);
            }

            if(requestObject.IsSetParControl())
            {
                context.Writer.WritePropertyName("parControl");
                context.Writer.WriteStringValue(requestObject.ParControl);
            }

            if(requestObject.IsSetParDenominator())
            {
                context.Writer.WritePropertyName("parDenominator");
                context.Writer.WriteNumberValue(requestObject.ParDenominator.Value);
            }

            if(requestObject.IsSetParNumerator())
            {
                context.Writer.WritePropertyName("parNumerator");
                context.Writer.WriteNumberValue(requestObject.ParNumerator.Value);
            }

            if(requestObject.IsSetQualityTuningLevel())
            {
                context.Writer.WritePropertyName("qualityTuningLevel");
                context.Writer.WriteStringValue(requestObject.QualityTuningLevel);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.WriteStringValue(requestObject.RateControlMode);
            }

            if(requestObject.IsSetScanTypeConversionMode())
            {
                context.Writer.WritePropertyName("scanTypeConversionMode");
                context.Writer.WriteStringValue(requestObject.ScanTypeConversionMode);
            }

            if(requestObject.IsSetSceneChangeDetect())
            {
                context.Writer.WritePropertyName("sceneChangeDetect");
                context.Writer.WriteStringValue(requestObject.SceneChangeDetect);
            }

            if(requestObject.IsSetSlowPal())
            {
                context.Writer.WritePropertyName("slowPal");
                context.Writer.WriteStringValue(requestObject.SlowPal);
            }

            if(requestObject.IsSetSoftness())
            {
                context.Writer.WritePropertyName("softness");
                context.Writer.WriteNumberValue(requestObject.Softness.Value);
            }

            if(requestObject.IsSetSpatialAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("spatialAdaptiveQuantization");
                context.Writer.WriteStringValue(requestObject.SpatialAdaptiveQuantization);
            }

            if(requestObject.IsSetSyntax())
            {
                context.Writer.WritePropertyName("syntax");
                context.Writer.WriteStringValue(requestObject.Syntax);
            }

            if(requestObject.IsSetTelecine())
            {
                context.Writer.WritePropertyName("telecine");
                context.Writer.WriteStringValue(requestObject.Telecine);
            }

            if(requestObject.IsSetTemporalAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("temporalAdaptiveQuantization");
                context.Writer.WriteStringValue(requestObject.TemporalAdaptiveQuantization);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Mpeg2SettingsMarshaller Instance = new Mpeg2SettingsMarshaller();

    }
}