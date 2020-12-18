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
using Aliyun.Acs.imagerecog.Model.V20190930;

namespace Aliyun.Acs.imagerecog.Transform.V20190930
{
    public class RecognizeVehicleTypeResponseUnmarshaller
    {
        public static RecognizeVehicleTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeVehicleTypeResponse recognizeVehicleTypeResponse = new RecognizeVehicleTypeResponse();

			recognizeVehicleTypeResponse.HttpResponse = _ctx.HttpResponse;
			recognizeVehicleTypeResponse.RequestId = _ctx.StringValue("RecognizeVehicleType.RequestId");

			RecognizeVehicleTypeResponse.RecognizeVehicleType_Data data = new RecognizeVehicleTypeResponse.RecognizeVehicleType_Data();
			data.Threshold = _ctx.FloatValue("RecognizeVehicleType.Data.Threshold");

			List<RecognizeVehicleTypeResponse.RecognizeVehicleType_Data.RecognizeVehicleType_Element> data_elements = new List<RecognizeVehicleTypeResponse.RecognizeVehicleType_Data.RecognizeVehicleType_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeVehicleType.Data.Elements.Length"); i++) {
				RecognizeVehicleTypeResponse.RecognizeVehicleType_Data.RecognizeVehicleType_Element element = new RecognizeVehicleTypeResponse.RecognizeVehicleType_Data.RecognizeVehicleType_Element();
				element.Name = _ctx.StringValue("RecognizeVehicleType.Data.Elements["+ i +"].Name");
				element.Score = _ctx.FloatValue("RecognizeVehicleType.Data.Elements["+ i +"].Score");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeVehicleTypeResponse.Data = data;
        
			return recognizeVehicleTypeResponse;
        }
    }
}
