/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterComponentsResponseUnmarshaller
    {
        public static DescribeCasterComponentsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterComponentsResponse describeCasterComponentsResponse = new DescribeCasterComponentsResponse();

			describeCasterComponentsResponse.HttpResponse = context.HttpResponse;
			describeCasterComponentsResponse.RequestId = context.StringValue("DescribeCasterComponents.RequestId");
			describeCasterComponentsResponse.Total = context.IntegerValue("DescribeCasterComponents.Total");

			List<DescribeCasterComponentsResponse.DescribeCasterComponents_Component> describeCasterComponentsResponse_components = new List<DescribeCasterComponentsResponse.DescribeCasterComponents_Component>();
			for (int i = 0; i < context.Length("DescribeCasterComponents.Components.Length"); i++) {
				DescribeCasterComponentsResponse.DescribeCasterComponents_Component component = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component();
				component.ComponentId = context.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentId");
				component.ComponentName = context.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentName");
				component.LocationId = context.StringValue("DescribeCasterComponents.Components["+ i +"].LocationId");
				component.ComponentType = context.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentType");
				component.Effect = context.StringValue("DescribeCasterComponents.Components["+ i +"].Effect");

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ComponentLayer componentLayer = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ComponentLayer();
				componentLayer.HeightNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.HeightNormalized");
				componentLayer.WidthNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.WidthNormalized");
				componentLayer.PositionRefer = context.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionRefer");
				componentLayer.Transparency = context.IntegerValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.Transparency");

				List<string> componentLayer_positionNormalizeds = new List<string>();
				for (int j = 0; j < context.Length("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionNormalizeds.Length"); j++) {
					componentLayer_positionNormalizeds.Add(context.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionNormalizeds["+ j +"]"));
				}
				componentLayer.PositionNormalizeds = componentLayer_positionNormalizeds;
				component.ComponentLayer = componentLayer;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_TextLayerContent textLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_TextLayerContent();
				textLayerContent.Text = context.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.Text");
				textLayerContent.Color = context.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.Color");
				textLayerContent.FontName = context.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.FontName");
				textLayerContent.SizeNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.SizeNormalized");
				textLayerContent.BorderWidthNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.BorderWidthNormalized");
				textLayerContent.BorderColor = context.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.BorderColor");
				component.TextLayerContent = textLayerContent;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ImageLayerContent imageLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ImageLayerContent();
				imageLayerContent.MaterialId = context.StringValue("DescribeCasterComponents.Components["+ i +"].ImageLayerContent.MaterialId");
				component.ImageLayerContent = imageLayerContent;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_CaptionLayerContent captionLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_CaptionLayerContent();
				captionLayerContent.LocationId = context.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.LocationId");
				captionLayerContent.PtsOffset = context.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.PtsOffset");
				captionLayerContent.WordsCount = context.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordsCount");
				captionLayerContent.Color = context.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.Color");
				captionLayerContent.FontName = context.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.FontName");
				captionLayerContent.SizeNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.SizeNormalized");
				captionLayerContent.BorderWidthNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.BorderWidthNormalized");
				captionLayerContent.BorderColor = context.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.BorderColor");
				captionLayerContent.WordCountPerLine = context.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordCountPerLine");
				captionLayerContent.WordSpaceNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordSpaceNormalized");
				captionLayerContent.LineSpaceNormalized = context.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.LineSpaceNormalized");
				component.CaptionLayerContent = captionLayerContent;

				describeCasterComponentsResponse_components.Add(component);
			}
			describeCasterComponentsResponse.Components = describeCasterComponentsResponse_components;
        
			return describeCasterComponentsResponse;
        }
    }
}
