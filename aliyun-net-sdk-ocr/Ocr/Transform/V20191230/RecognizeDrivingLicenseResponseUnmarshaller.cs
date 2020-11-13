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
        public static RecognizeDrivingLicenseResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeDrivingLicenseResponse recognizeDrivingLicenseResponse = new RecognizeDrivingLicenseResponse();

			recognizeDrivingLicenseResponse.HttpResponse = context.HttpResponse;
			recognizeDrivingLicenseResponse.RequestId = context.StringValue("RecognizeDrivingLicense.RequestId");

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data data = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data();

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_FaceResult faceResult = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_FaceResult();
			faceResult.PlateNumber = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.PlateNumber");
			faceResult.VehicleType = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.VehicleType");
			faceResult.Owner = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.Owner");
			faceResult.UseCharacter = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.UseCharacter");
			faceResult.Address = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.Address");
			faceResult.Model = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.Model");
			faceResult.Vin = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.Vin");
			faceResult.EngineNumber = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.EngineNumber");
			faceResult.RegisterDate = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.RegisterDate");
			faceResult.IssueDate = context.StringValue("RecognizeDrivingLicense.Data.FaceResult.IssueDate");
			data.FaceResult = faceResult;

			RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_BackResult backResult = new RecognizeDrivingLicenseResponse.RecognizeDrivingLicense_Data.RecognizeDrivingLicense_BackResult();
			backResult.ApprovedPassengerCapacity = context.StringValue("RecognizeDrivingLicense.Data.BackResult.ApprovedPassengerCapacity");
			backResult.ApprovedLoad = context.StringValue("RecognizeDrivingLicense.Data.BackResult.ApprovedLoad");
			backResult.FileNumber = context.StringValue("RecognizeDrivingLicense.Data.BackResult.FileNumber");
			backResult.GrossMass = context.StringValue("RecognizeDrivingLicense.Data.BackResult.GrossMass");
			backResult.EnergyType = context.StringValue("RecognizeDrivingLicense.Data.BackResult.EnergyType");
			backResult.InspectionRecord = context.StringValue("RecognizeDrivingLicense.Data.BackResult.InspectionRecord");
			backResult.OverallDimension = context.StringValue("RecognizeDrivingLicense.Data.BackResult.OverallDimension");
			backResult.TractionMass = context.StringValue("RecognizeDrivingLicense.Data.BackResult.TractionMass");
			backResult.UnladenMass = context.StringValue("RecognizeDrivingLicense.Data.BackResult.UnladenMass");
			backResult.PlateNumber = context.StringValue("RecognizeDrivingLicense.Data.BackResult.PlateNumber");
			data.BackResult = backResult;
			recognizeDrivingLicenseResponse.Data = data;
        
			return recognizeDrivingLicenseResponse;
        }
    }
}
