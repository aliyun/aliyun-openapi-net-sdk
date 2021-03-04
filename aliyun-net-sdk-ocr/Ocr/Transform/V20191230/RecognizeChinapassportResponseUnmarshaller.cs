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
        public static RecognizeChinapassportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeChinapassportResponse recognizeChinapassportResponse = new RecognizeChinapassportResponse();

			recognizeChinapassportResponse.HttpResponse = _ctx.HttpResponse;
			recognizeChinapassportResponse.RequestId = _ctx.StringValue("RecognizeChinapassport.RequestId");

			RecognizeChinapassportResponse.RecognizeChinapassport_Data data = new RecognizeChinapassportResponse.RecognizeChinapassport_Data();
			data.Authority = _ctx.StringValue("RecognizeChinapassport.Data.Authority");
			data.BirthDate = _ctx.StringValue("RecognizeChinapassport.Data.BirthDate");
			data.BirthDay = _ctx.StringValue("RecognizeChinapassport.Data.BirthDay");
			data.BirthPlace = _ctx.StringValue("RecognizeChinapassport.Data.BirthPlace");
			data.BirthPlaceRaw = _ctx.StringValue("RecognizeChinapassport.Data.BirthPlaceRaw");
			data.Country = _ctx.StringValue("RecognizeChinapassport.Data.Country");
			data.ExpiryDate = _ctx.StringValue("RecognizeChinapassport.Data.ExpiryDate");
			data.ExpiryDay = _ctx.StringValue("RecognizeChinapassport.Data.ExpiryDay");
			data.IssueDate = _ctx.StringValue("RecognizeChinapassport.Data.IssueDate");
			data.IssuePlace = _ctx.StringValue("RecognizeChinapassport.Data.IssuePlace");
			data.IssuePlaceRaw = _ctx.StringValue("RecognizeChinapassport.Data.IssuePlaceRaw");
			data.LineZero = _ctx.StringValue("RecognizeChinapassport.Data.LineZero");
			data.LineOne = _ctx.StringValue("RecognizeChinapassport.Data.LineOne");
			data.Name = _ctx.StringValue("RecognizeChinapassport.Data.Name");
			data.NameChinese = _ctx.StringValue("RecognizeChinapassport.Data.NameChinese");
			data.NameChineseRaw = _ctx.StringValue("RecognizeChinapassport.Data.NameChineseRaw");
			data.PassportNo = _ctx.StringValue("RecognizeChinapassport.Data.PassportNo");
			data.PersonId = _ctx.StringValue("RecognizeChinapassport.Data.PersonId");
			data.Sex = _ctx.StringValue("RecognizeChinapassport.Data.Sex");
			data.SourceCountry = _ctx.StringValue("RecognizeChinapassport.Data.SourceCountry");
			data.Success = _ctx.BooleanValue("RecognizeChinapassport.Data.Success");
			data.Type = _ctx.StringValue("RecognizeChinapassport.Data.Type");
			recognizeChinapassportResponse.Data = data;
        
			return recognizeChinapassportResponse;
        }
    }
}
