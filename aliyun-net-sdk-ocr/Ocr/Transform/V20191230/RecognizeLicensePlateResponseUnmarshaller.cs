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
        public static RecognizeLicensePlateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeLicensePlateResponse recognizeLicensePlateResponse = new RecognizeLicensePlateResponse();

			recognizeLicensePlateResponse.HttpResponse = _ctx.HttpResponse;
			recognizeLicensePlateResponse.RequestId = _ctx.StringValue("RecognizeLicensePlate.RequestId");
			recognizeLicensePlateResponse.Code = _ctx.StringValue("RecognizeLicensePlate.Code");
			recognizeLicensePlateResponse.Message = _ctx.StringValue("RecognizeLicensePlate.Message");

			RecognizeLicensePlateResponse.RecognizeLicensePlate_Data data = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data();

			List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate> data_plates = new List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate>();
			for (int i = 0; i < _ctx.Length("RecognizeLicensePlate.Data.Plates.Length"); i++) {
				RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate plate = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate();
				plate.PlateTypeConfidence = _ctx.FloatValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateTypeConfidence");
				plate.PlateType = _ctx.StringValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateType");
				plate.Confidence = _ctx.FloatValue("RecognizeLicensePlate.Data.Plates["+ i +"].Confidence");
				plate.PlateNumber = _ctx.StringValue("RecognizeLicensePlate.Data.Plates["+ i +"].PlateNumber");

				RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_Roi roi = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_Roi();
				roi.W = _ctx.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.W");
				roi.H = _ctx.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.H");
				roi.Y = _ctx.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.Y");
				roi.X = _ctx.IntegerValue("RecognizeLicensePlate.Data.Plates["+ i +"].Roi.X");
				plate.Roi = roi;

				List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_PositionsItem> plate_positions = new List<RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_PositionsItem>();
				for (int j = 0; j < _ctx.Length("RecognizeLicensePlate.Data.Plates["+ i +"].Positions.Length"); j++) {
					RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_PositionsItem positionsItem = new RecognizeLicensePlateResponse.RecognizeLicensePlate_Data.RecognizeLicensePlate_Plate.RecognizeLicensePlate_PositionsItem();
					positionsItem.X = _ctx.LongValue("RecognizeLicensePlate.Data.Plates["+ i +"].Positions["+ j +"].X");
					positionsItem.Y = _ctx.LongValue("RecognizeLicensePlate.Data.Plates["+ i +"].Positions["+ j +"].Y");

					plate_positions.Add(positionsItem);
				}
				plate.Positions = plate_positions;

				data_plates.Add(plate);
			}
			data.Plates = data_plates;
			recognizeLicensePlateResponse.Data = data;
        
			return recognizeLicensePlateResponse;
        }
    }
}
