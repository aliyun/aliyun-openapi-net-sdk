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
    public class RecognizeBusinessCardResponseUnmarshaller
    {
        public static RecognizeBusinessCardResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeBusinessCardResponse recognizeBusinessCardResponse = new RecognizeBusinessCardResponse();

			recognizeBusinessCardResponse.HttpResponse = _ctx.HttpResponse;
			recognizeBusinessCardResponse.RequestId = _ctx.StringValue("RecognizeBusinessCard.RequestId");

			RecognizeBusinessCardResponse.RecognizeBusinessCard_Data data = new RecognizeBusinessCardResponse.RecognizeBusinessCard_Data();
			data.Name = _ctx.StringValue("RecognizeBusinessCard.Data.Name");

			List<string> data_companies = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.Companies.Length"); i++) {
				data_companies.Add(_ctx.StringValue("RecognizeBusinessCard.Data.Companies["+ i +"]"));
			}
			data.Companies = data_companies;

			List<string> data_departments = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.Departments.Length"); i++) {
				data_departments.Add(_ctx.StringValue("RecognizeBusinessCard.Data.Departments["+ i +"]"));
			}
			data.Departments = data_departments;

			List<string> data_titles = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.Titles.Length"); i++) {
				data_titles.Add(_ctx.StringValue("RecognizeBusinessCard.Data.Titles["+ i +"]"));
			}
			data.Titles = data_titles;

			List<string> data_cellPhoneNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.CellPhoneNumbers.Length"); i++) {
				data_cellPhoneNumbers.Add(_ctx.StringValue("RecognizeBusinessCard.Data.CellPhoneNumbers["+ i +"]"));
			}
			data.CellPhoneNumbers = data_cellPhoneNumbers;

			List<string> data_officePhoneNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.OfficePhoneNumbers.Length"); i++) {
				data_officePhoneNumbers.Add(_ctx.StringValue("RecognizeBusinessCard.Data.OfficePhoneNumbers["+ i +"]"));
			}
			data.OfficePhoneNumbers = data_officePhoneNumbers;

			List<string> data_addresses = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.Addresses.Length"); i++) {
				data_addresses.Add(_ctx.StringValue("RecognizeBusinessCard.Data.Addresses["+ i +"]"));
			}
			data.Addresses = data_addresses;

			List<string> data_emails = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeBusinessCard.Data.Emails.Length"); i++) {
				data_emails.Add(_ctx.StringValue("RecognizeBusinessCard.Data.Emails["+ i +"]"));
			}
			data.Emails = data_emails;
			recognizeBusinessCardResponse.Data = data;
        
			return recognizeBusinessCardResponse;
        }
    }
}
