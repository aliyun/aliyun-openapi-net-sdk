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
        public static DetectLungNoduleResponse Unmarshall(UnmarshallerContext context)
        {
			DetectLungNoduleResponse detectLungNoduleResponse = new DetectLungNoduleResponse();

			detectLungNoduleResponse.HttpResponse = context.HttpResponse;
			detectLungNoduleResponse.RequestId = context.StringValue("DetectLungNodule.RequestId");

			DetectLungNoduleResponse.DetectLungNodule_Data data = new DetectLungNoduleResponse.DetectLungNodule_Data();

			List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie> data_series = new List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie>();
			for (int i = 0; i < context.Length("DetectLungNodule.Data.Series.Length"); i++) {
				DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie serie = new DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie();
				serie.SeriesInstanceUid = context.StringValue("DetectLungNodule.Data.Series["+ i +"].SeriesInstanceUid");

				List<string> serie_origin = new List<string>();
				for (int j = 0; j < context.Length("DetectLungNodule.Data.Series["+ i +"].Origin.Length"); j++) {
					serie_origin.Add(context.StringValue("DetectLungNodule.Data.Series["+ i +"].Origin["+ j +"]"));
				}
				serie.Origin = serie_origin;

				List<string> serie_spacing = new List<string>();
				for (int j = 0; j < context.Length("DetectLungNodule.Data.Series["+ i +"].Spacing.Length"); j++) {
					serie_spacing.Add(context.StringValue("DetectLungNodule.Data.Series["+ i +"].Spacing["+ j +"]"));
				}
				serie.Spacing = serie_spacing;

				List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element> serie_elements = new List<DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element>();
				for (int j = 0; j < context.Length("DetectLungNodule.Data.Series["+ i +"].Elements.Length"); j++) {
					DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element element = new DetectLungNoduleResponse.DetectLungNodule_Data.DetectLungNodule_Serie.DetectLungNodule_Element();
					element.Category = context.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Category");
					element.Confidence = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Confidence");
					element.Diameter = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Diameter");
					element.Lobe = context.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Lobe");
					element.Lung = context.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Lung");
					element.X = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].X");
					element.Z = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Z");
					element.Y = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].Y");
					element.ImageX = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageX");
					element.ImageY = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageY");
					element.ImageZ = context.FloatValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].ImageZ");
					element.SOPInstanceUID = context.StringValue("DetectLungNodule.Data.Series["+ i +"].Elements["+ j +"].SOPInstanceUID");

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
