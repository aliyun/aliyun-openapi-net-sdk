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
    public class RecognizeChinapassportResponseUnmarshaller
    {
        public static RecognizeChinapassportResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeChinapassportResponse recognizeChinapassportResponse = new RecognizeChinapassportResponse();

			recognizeChinapassportResponse.HttpResponse = context.HttpResponse;
			recognizeChinapassportResponse.RequestId = context.StringValue("RecognizeChinapassport.RequestId");

			RecognizeChinapassportResponse.RecognizeChinapassport_Data data = new RecognizeChinapassportResponse.RecognizeChinapassport_Data();
			data.Authority = context.StringValue("RecognizeChinapassport.Data.Authority");
			data.BirthDate = context.StringValue("RecognizeChinapassport.Data.BirthDate");
			data.BirthDay = context.StringValue("RecognizeChinapassport.Data.BirthDay");
			data.BirthPlace = context.StringValue("RecognizeChinapassport.Data.BirthPlace");
			data.BirthPlaceRaw = context.StringValue("RecognizeChinapassport.Data.BirthPlaceRaw");
			data.Country = context.StringValue("RecognizeChinapassport.Data.Country");
			data.ExpiryDate = context.StringValue("RecognizeChinapassport.Data.ExpiryDate");
			data.ExpiryDay = context.StringValue("RecognizeChinapassport.Data.ExpiryDay");
			data.IssueDate = context.StringValue("RecognizeChinapassport.Data.IssueDate");
			data.IssuePlace = context.StringValue("RecognizeChinapassport.Data.IssuePlace");
			data.IssuePlaceRaw = context.StringValue("RecognizeChinapassport.Data.IssuePlaceRaw");
			data.LineZero = context.StringValue("RecognizeChinapassport.Data.LineZero");
			data.LineOne = context.StringValue("RecognizeChinapassport.Data.LineOne");
			data.Name = context.StringValue("RecognizeChinapassport.Data.Name");
			data.NameChinese = context.StringValue("RecognizeChinapassport.Data.NameChinese");
			data.NameChineseRaw = context.StringValue("RecognizeChinapassport.Data.NameChineseRaw");
			data.PassportNo = context.StringValue("RecognizeChinapassport.Data.PassportNo");
			data.PersonId = context.StringValue("RecognizeChinapassport.Data.PersonId");
			data.Sex = context.StringValue("RecognizeChinapassport.Data.Sex");
			data.SourceCountry = context.StringValue("RecognizeChinapassport.Data.SourceCountry");
			data.Success = context.BooleanValue("RecognizeChinapassport.Data.Success");
			data.Type = context.StringValue("RecognizeChinapassport.Data.Type");
			recognizeChinapassportResponse.Data = data;
        
			return recognizeChinapassportResponse;
        }
    }
}
