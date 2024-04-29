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
        public static DescribeCasterComponentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterComponentsResponse describeCasterComponentsResponse = new DescribeCasterComponentsResponse();

			describeCasterComponentsResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterComponentsResponse.RequestId = _ctx.StringValue("DescribeCasterComponents.RequestId");
			describeCasterComponentsResponse.Total = _ctx.IntegerValue("DescribeCasterComponents.Total");

			List<DescribeCasterComponentsResponse.DescribeCasterComponents_Component> describeCasterComponentsResponse_components = new List<DescribeCasterComponentsResponse.DescribeCasterComponents_Component>();
			for (int i = 0; i < _ctx.Length("DescribeCasterComponents.Components.Length"); i++) {
				DescribeCasterComponentsResponse.DescribeCasterComponents_Component component = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component();
				component.ComponentId = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentId");
				component.ComponentName = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentName");
				component.ComponentType = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentType");
				component.Effect = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].Effect");
				component.LocationId = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].LocationId");

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_CaptionLayerContent captionLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_CaptionLayerContent();
				captionLayerContent.BorderColor = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.BorderColor");
				captionLayerContent.BorderWidthNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.BorderWidthNormalized");
				captionLayerContent.Color = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.Color");
				captionLayerContent.FontName = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.FontName");
				captionLayerContent.LineSpaceNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.LineSpaceNormalized");
				captionLayerContent.LocationId = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.LocationId");
				captionLayerContent.PtsOffset = _ctx.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.PtsOffset");
				captionLayerContent.ShowSourceLan = _ctx.BooleanValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.ShowSourceLan");
				captionLayerContent.SizeNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.SizeNormalized");
				captionLayerContent.SourceLan = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.SourceLan");
				captionLayerContent.TargetLan = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.TargetLan");
				captionLayerContent.WordCountPerLine = _ctx.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordCountPerLine");
				captionLayerContent.WordSpaceNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordSpaceNormalized");
				captionLayerContent.WordsCount = _ctx.IntegerValue("DescribeCasterComponents.Components["+ i +"].CaptionLayerContent.WordsCount");
				component.CaptionLayerContent = captionLayerContent;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ComponentLayer componentLayer = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ComponentLayer();
				componentLayer.HeightNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.HeightNormalized");
				componentLayer.PositionRefer = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionRefer");
				componentLayer.Transparency = _ctx.IntegerValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.Transparency");
				componentLayer.WidthNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.WidthNormalized");

				List<string> componentLayer_positionNormalizeds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionNormalizeds.Length"); j++) {
					componentLayer_positionNormalizeds.Add(_ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ComponentLayer.PositionNormalizeds["+ j +"]"));
				}
				componentLayer.PositionNormalizeds = componentLayer_positionNormalizeds;
				component.ComponentLayer = componentLayer;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ImageLayerContent imageLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_ImageLayerContent();
				imageLayerContent.MaterialId = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].ImageLayerContent.MaterialId");
				component.ImageLayerContent = imageLayerContent;

				DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_TextLayerContent textLayerContent = new DescribeCasterComponentsResponse.DescribeCasterComponents_Component.DescribeCasterComponents_TextLayerContent();
				textLayerContent.BorderColor = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.BorderColor");
				textLayerContent.BorderWidthNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.BorderWidthNormalized");
				textLayerContent.Color = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.Color");
				textLayerContent.FontName = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.FontName");
				textLayerContent.SizeNormalized = _ctx.FloatValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.SizeNormalized");
				textLayerContent.Text = _ctx.StringValue("DescribeCasterComponents.Components["+ i +"].TextLayerContent.Text");
				component.TextLayerContent = textLayerContent;

				describeCasterComponentsResponse_components.Add(component);
			}
			describeCasterComponentsResponse.Components = describeCasterComponentsResponse_components;
        
			return describeCasterComponentsResponse;
        }
    }
}
