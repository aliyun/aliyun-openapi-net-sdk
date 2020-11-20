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
    public class RecognizeBusinessLicenseResponseUnmarshaller
    {
        public static RecognizeBusinessLicenseResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeBusinessLicenseResponse recognizeBusinessLicenseResponse = new RecognizeBusinessLicenseResponse();

			recognizeBusinessLicenseResponse.HttpResponse = context.HttpResponse;
			recognizeBusinessLicenseResponse.RequestId = context.StringValue("RecognizeBusinessLicense.RequestId");

			RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data data = new RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data();
			data.Angle = context.FloatValue("RecognizeBusinessLicense.Data.Angle");
			data.RegisterNumber = context.StringValue("RecognizeBusinessLicense.Data.RegisterNumber");
			data.Name = context.StringValue("RecognizeBusinessLicense.Data.Name");
			data.Type = context.StringValue("RecognizeBusinessLicense.Data.Type");
			data.LegalPerson = context.StringValue("RecognizeBusinessLicense.Data.LegalPerson");
			data.EstablishDate = context.StringValue("RecognizeBusinessLicense.Data.EstablishDate");
			data.ValidPeriod = context.StringValue("RecognizeBusinessLicense.Data.ValidPeriod");
			data.Address = context.StringValue("RecognizeBusinessLicense.Data.Address");
			data.Capital = context.StringValue("RecognizeBusinessLicense.Data.Capital");
			data.Business = context.StringValue("RecognizeBusinessLicense.Data.Business");

			RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Emblem emblem = new RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Emblem();
			emblem.Top = context.IntegerValue("RecognizeBusinessLicense.Data.Emblem.Top");
			emblem.Left = context.IntegerValue("RecognizeBusinessLicense.Data.Emblem.Left");
			emblem.Height = context.IntegerValue("RecognizeBusinessLicense.Data.Emblem.Height");
			emblem.Width = context.IntegerValue("RecognizeBusinessLicense.Data.Emblem.Width");
			data.Emblem = emblem;

			RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Title title = new RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Title();
			title.Top = context.IntegerValue("RecognizeBusinessLicense.Data.Title.Top");
			title.Left = context.IntegerValue("RecognizeBusinessLicense.Data.Title.Left");
			title.Height = context.IntegerValue("RecognizeBusinessLicense.Data.Title.Height");
			title.Width = context.IntegerValue("RecognizeBusinessLicense.Data.Title.Width");
			data.Title = title;

			RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Stamp stamp = new RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_Stamp();
			stamp.Top = context.IntegerValue("RecognizeBusinessLicense.Data.Stamp.Top");
			stamp.Left = context.IntegerValue("RecognizeBusinessLicense.Data.Stamp.Left");
			stamp.Height = context.IntegerValue("RecognizeBusinessLicense.Data.Stamp.Height");
			stamp.Width = context.IntegerValue("RecognizeBusinessLicense.Data.Stamp.Width");
			data.Stamp = stamp;

			RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_QRCode qRCode = new RecognizeBusinessLicenseResponse.RecognizeBusinessLicense_Data.RecognizeBusinessLicense_QRCode();
			qRCode.Top = context.IntegerValue("RecognizeBusinessLicense.Data.QRCode.Top");
			qRCode.Left = context.IntegerValue("RecognizeBusinessLicense.Data.QRCode.Left");
			qRCode.Height = context.IntegerValue("RecognizeBusinessLicense.Data.QRCode.Height");
			qRCode.Width = context.IntegerValue("RecognizeBusinessLicense.Data.QRCode.Width");
			data.QRCode = qRCode;
			recognizeBusinessLicenseResponse.Data = data;
        
			return recognizeBusinessLicenseResponse;
        }
    }
}
