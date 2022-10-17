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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class DetectLungNoduleResponseUnmarshaller
    {
        public static DetectLungNoduleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectLungNoduleResponse detectLungNoduleResponse = new DetectLungNoduleResponse();

			detectLungNoduleResponse.HttpResponse = _ctx.HttpResponse;
			detectLungNoduleResponse.RequestId = _ctx.StringValue("DetectLungNodule.RequestId");
			detectLungNoduleResponse.Code = _ctx.StringValue("DetectLungNodule.Code");
			detectLungNoduleResponse.Message = _ctx.StringValue("DetectLungNodule.Message");

			DetectLungNoduleResponse.DetectLungNodule_Data data = new DetectLungNoduleResponse.DetectLungNodule_Data();

			List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie> data_series = new List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie>();
			for (int i = 0; i < _ctx.Length("DetectLungNodule.Data.Series.Length"); i++) {
				DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie serie = new DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie();
				serie.SeriesInstanceUid = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].SeriesInstanceUid");
				serie.Report = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Report");

				List<string> serie_origin = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLungNodule.Data.Series["+ i +"].Origin.Length"); j++) {
					serie_origin.Add(_ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Origin["+ j +"]"));
				}
				serie.Origin = serie_origin;

				List<string> serie_spacing = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLungNodule.Data.Series["+ i +"].Spacing.Length"); j++) {
					serie_spacing.Add(_ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Spacing["+ j +"]"));
				}
				serie.Spacing = serie_spacing;

				List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element> serie_elements = new List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element>();
				for (int j = 0; j < _ctx.Length("DetectLungNodule.Data.Series["+ i +"].Elements.Length"); j++) {
					DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element element = new DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element();
					element.Z = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Z");
					element.Lobe = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Lobe");
					element.MeanValue = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].MeanValue");
					element.ImageZ = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageZ");
					element.Lung = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Lung");
					element.Confidence = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Confidence");
					element.SOPInstanceUID = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].SOPInstanceUID");
					element.ImageX = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageX");
					element.Y = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Y");
					element.Category = _ctx.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Category");
					element.Volume = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Volume");
					element.ImageY = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageY");
					element.Diameter = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Diameter");
					element.X = _ctx.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].X");

					serie_elements.Add(element);
				}
				serie.Elements = serie_elements;

				data_series.Add(serie);
			}
			data.Series = data_series;
			detectLungNoduleResponse.Data = data;
        
			return detectLungNoduleResponse;
        }
    }
}
