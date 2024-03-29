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
    public class RecognizeDrivingLicenseResponseUnmarshaller
    {
        public static RecognizeDrivingLicenseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeDrivingLicenseResponse recognizeDrivingLicenseResponse = new RecognizeDrivingLicenseResponse();

			recognizeDrivingLicenseResponse.HttpResponse = _ctx.HttpResponse;
			recognizeDrivingLicenseResponse.RequestId = _ctx.StringValue("RecognizeDrivingLicense.RequestId");

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data data = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data();

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_BackResult backResult = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_BackResult();
			backResult.OverallDimension = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.OverallDimension");
			backResult.InspectionRecord = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.InspectionRecord");
			backResult.UnladenMass = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.UnladenMass");
			backResult.FileNumber = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.FileNumber");
			backResult.TractionMass = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.TractionMass");
			backResult.GrossMass = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.GrossMass");
			backResult.PlateNumber = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.PlateNumber");
			backResult.ApprovedPassengerCapacity = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.ApprovedPassengerCapacity");
			backResult.EnergyType = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.EnergyType");
			backResult.ApprovedLoad = _ctx.StringValue("RecognizeDrivingLicense.Data.BackResult.ApprovedLoad");
			data.BackResult = backResult;

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_FaceResult faceResult = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_FaceResult();
			faceResult.IssueDate = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.IssueDate");
			faceResult.Model = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.Model");
			faceResult.VehicleType = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.VehicleType");
			faceResult.Owner = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.Owner");
			faceResult.EngineNumber = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.EngineNumber");
			faceResult.PlateNumber = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.PlateNumber");
			faceResult.Address = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.Address");
			faceResult.UseCharacter = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.UseCharacter");
			faceResult.Vin = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.Vin");
			faceResult.RegisterDate = _ctx.StringValue("RecognizeDrivingLicense.Data.FaceResult.RegisterDate");
			data.FaceResult = faceResult;
			recognizeDrivingLicenseResponse.Data = data;
        
			return recognizeDrivingLicenseResponse;
        }
    }
}
