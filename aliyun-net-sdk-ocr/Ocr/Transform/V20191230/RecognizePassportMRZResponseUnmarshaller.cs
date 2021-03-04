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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizePassportMRZResponseUnmarshaller
    {
        public static RecognizePassportMRZResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizePassportMRZResponse recognizePassportMRZResponse = new RecognizePassportMRZResponse();

			recognizePassportMRZResponse.HttpResponse = _ctx.HttpResponse;
			recognizePassportMRZResponse.RequestId = _ctx.StringValue("RecognizePassportMRZ.RequestId");

			RecognizePassportMRZResponse.RecognizePassportMRZ_Data data = new RecognizePassportMRZResponse.RecognizePassportMRZ_Data();

			List<RecognizePassportMRZResponse.RecognizePassportMRZ_Data.RecognizePassportMRZ_Region> data_regions = new List<RecognizePassportMRZResponse.RecognizePassportMRZ_Data.RecognizePassportMRZ_Region>();
			for (int i = 0; i < _ctx.Length("RecognizePassportMRZ.Data.Regions.Length"); i++) {
				RecognizePassportMRZResponse.RecognizePassportMRZ_Data.RecognizePassportMRZ_Region region = new RecognizePassportMRZResponse.RecognizePassportMRZ_Data.RecognizePassportMRZ_Region();
				region.Name = _ctx.StringValue("RecognizePassportMRZ.Data.Regions["+ i +"].Name");
				region.RecognitionScore = _ctx.FloatValue("RecognizePassportMRZ.Data.Regions["+ i +"].RecognitionScore");
				region.Content = _ctx.StringValue("RecognizePassportMRZ.Data.Regions["+ i +"].Content");
				region.DetectionScore = _ctx.FloatValue("RecognizePassportMRZ.Data.Regions["+ i +"].DetectionScore");

				List<string> region_bandBoxes = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizePassportMRZ.Data.Regions["+ i +"].BandBoxes.Length"); j++) {
					region_bandBoxes.Add(_ctx.StringValue("RecognizePassportMRZ.Data.Regions["+ i +"].BandBoxes["+ j +"]"));
				}
				region.BandBoxes = region_bandBoxes;

				data_regions.Add(region);
			}
			data.Regions = data_regions;
			recognizePassportMRZResponse.Data = data;
        
			return recognizePassportMRZResponse;
        }
    }
}
