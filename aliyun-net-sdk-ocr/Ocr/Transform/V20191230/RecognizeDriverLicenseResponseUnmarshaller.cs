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
    public class RecognizeDriverLicenseResponseUnmarshaller
    {
        public static RecognizeDriverLicenseResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeDriverLicenseResponse recognizeDriverLicenseResponse = new RecognizeDriverLicenseResponse();

			recognizeDriverLicenseResponse.HttpResponse = context.HttpResponse;
			recognizeDriverLicenseResponse.RequestId = context.StringValue("RecognizeDriverLicense.RequestId");

			RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data data = new RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data();

			RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data.RecognizeDriverLicense_FaceResult faceResult = new RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data.RecognizeDriverLicense_FaceResult();
			faceResult.Name = context.StringValue("RecognizeDriverLicense.Data.FaceResult.Name");
			faceResult.LicenseNumber = context.StringValue("RecognizeDriverLicense.Data.FaceResult.LicenseNumber");
			faceResult.VehicleType = context.StringValue("RecognizeDriverLicense.Data.FaceResult.VehicleType");
			faceResult.StartDate = context.StringValue("RecognizeDriverLicense.Data.FaceResult.StartDate");
			faceResult.EndDate = context.StringValue("RecognizeDriverLicense.Data.FaceResult.EndDate");
			faceResult.IssueDate = context.StringValue("RecognizeDriverLicense.Data.FaceResult.IssueDate");
			faceResult.Address = context.StringValue("RecognizeDriverLicense.Data.FaceResult.Address");
			faceResult.Gender = context.StringValue("RecognizeDriverLicense.Data.FaceResult.Gender");
			data.FaceResult = faceResult;

			RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data.RecognizeDriverLicense_BackResult backResult = new RecognizeDriverLicenseResponse.RecognizeDriverLicense_Data.RecognizeDriverLicense_BackResult();
			backResult.ArchiveNumber = context.StringValue("RecognizeDriverLicense.Data.BackResult.ArchiveNumber");
			data.BackResult = backResult;
			recognizeDriverLicenseResponse.Data = data;
        
			return recognizeDriverLicenseResponse;
        }
    }
}
