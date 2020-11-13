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
    public class RecognizeLicensePlateResponseUnmarshaller
    {
        public static RecognizeLicensePlateResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeLicensePlateResponse recognizeLicensePlateResponse = new RecognizeLicensePlateResponse();

			recognizeLicensePlateResponse.HttpResponse = context.HttpResponse;
			recognizeLicensePlateResponse.RequestId = context.StringValue("RecognizeLicensePlate.RequestId");

			RecognizeLicensePlateResponse.RecognizeLicensePlate_Data data = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data();

			List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate> data_plates = new List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate>();
			for (int i = 0; i < context.Length("RecognizeLicensePlate.Data.Plates.Length"); i++) {
				RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate plate = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate();
				plate.Confidence = context.FloatValue("RecognizeLicensePlate.Data.Plates["+ i +"].Confidence");
				plate.PlateNumber = context.StringValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateNumber");
				plate.PlateType = context.StringValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateType");
				plate.PlateTypeConfidence = context.FloatValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateTypeConfidence");

				RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_Roi roi = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_Roi();
				roi.H = context.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.H");
				roi.W = context.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.W");
				roi.X = context.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.X");
				roi.Y = context.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.Y");
				plate.Roi = roi;

				data_plates.Add(plate);
			}
			data.Plates = data_plates;
			recognizeLicensePlateResponse.Data = data;
        
			return recognizeLicensePlateResponse;
        }
    }
}
