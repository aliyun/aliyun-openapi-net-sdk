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
    public class RecognizeAccountPageResponseUnmarshaller
    {
        public static RecognizeAccountPageResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeAccountPageResponse recognizeAccountPageResponse = new RecognizeAccountPageResponse();

			recognizeAccountPageResponse.HttpResponse = context.HttpResponse;
			recognizeAccountPageResponse.RequestId = context.StringValue("RecognizeAccountPage.RequestId");

			RecognizeAccountPageResponse.RecognizeAccountPage_Data data = new RecognizeAccountPageResponse.RecognizeAccountPage_Data();
			data.Angle = context.FloatValue("RecognizeAccountPage.Data.Angle");
			data.Name = context.StringValue("RecognizeAccountPage.Data.Name");
			data.Gender = context.StringValue("RecognizeAccountPage.Data.Gender");
			data.Relation = context.StringValue("RecognizeAccountPage.Data.Relation");
			data.BirthPlace = context.StringValue("RecognizeAccountPage.Data.BirthPlace");
			data.Nationality = context.StringValue("RecognizeAccountPage.Data.Nationality");
			data.NativePlace = context.StringValue("RecognizeAccountPage.Data.NativePlace");
			data.BirthDate = context.StringValue("RecognizeAccountPage.Data.BirthDate");
			data.IDNumber = context.StringValue("RecognizeAccountPage.Data.IDNumber");

			RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_TitleArea titleArea = new RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_TitleArea();
			titleArea.Left = context.IntegerValue("RecognizeAccountPage.Data.TitleArea.Left");
			titleArea.Top = context.IntegerValue("RecognizeAccountPage.Data.TitleArea.Top");
			titleArea.Height = context.IntegerValue("RecognizeAccountPage.Data.TitleArea.Height");
			titleArea.Width = context.IntegerValue("RecognizeAccountPage.Data.TitleArea.Width");
			data.TitleArea = titleArea;

			List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_InvalidStampArea> data_invalidStampAreas = new List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_InvalidStampArea>();
			for (int i = 0; i < context.Length("RecognizeAccountPage.Data.InvalidStampAreas.Length"); i++) {
				RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_InvalidStampArea invalidStampArea = new RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_InvalidStampArea();
				invalidStampArea.Left = context.IntegerValue("RecognizeAccountPage.Data.InvalidStampAreas["+ i +"].Left");
				invalidStampArea.Top = context.IntegerValue("RecognizeAccountPage.Data.InvalidStampAreas["+ i +"].Top");
				invalidStampArea.Height = context.IntegerValue("RecognizeAccountPage.Data.InvalidStampAreas["+ i +"].Height");
				invalidStampArea.Width = context.IntegerValue("RecognizeAccountPage.Data.InvalidStampAreas["+ i +"].Width");

				data_invalidStampAreas.Add(invalidStampArea);
			}
			data.InvalidStampAreas = data_invalidStampAreas;

			List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_UndertakeStampArea> data_undertakeStampAreas = new List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_UndertakeStampArea>();
			for (int i = 0; i < context.Length("RecognizeAccountPage.Data.UndertakeStampAreas.Length"); i++) {
				RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_UndertakeStampArea undertakeStampArea = new RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_UndertakeStampArea();
				undertakeStampArea.Left = context.IntegerValue("RecognizeAccountPage.Data.UndertakeStampAreas["+ i +"].Left");
				undertakeStampArea.Top = context.IntegerValue("RecognizeAccountPage.Data.UndertakeStampAreas["+ i +"].Top");
				undertakeStampArea.Height = context.IntegerValue("RecognizeAccountPage.Data.UndertakeStampAreas["+ i +"].Height");
				undertakeStampArea.Width = context.IntegerValue("RecognizeAccountPage.Data.UndertakeStampAreas["+ i +"].Width");

				data_undertakeStampAreas.Add(undertakeStampArea);
			}
			data.UndertakeStampAreas = data_undertakeStampAreas;

			List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_RegisterStampArea> data_registerStampAreas = new List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_RegisterStampArea>();
			for (int i = 0; i < context.Length("RecognizeAccountPage.Data.RegisterStampAreas.Length"); i++) {
				RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_RegisterStampArea registerStampArea = new RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_RegisterStampArea();
				registerStampArea.Left = context.IntegerValue("RecognizeAccountPage.Data.RegisterStampAreas["+ i +"].Left");
				registerStampArea.Top = context.IntegerValue("RecognizeAccountPage.Data.RegisterStampAreas["+ i +"].Top");
				registerStampArea.Height = context.IntegerValue("RecognizeAccountPage.Data.RegisterStampAreas["+ i +"].Height");
				registerStampArea.Width = context.IntegerValue("RecognizeAccountPage.Data.RegisterStampAreas["+ i +"].Width");

				data_registerStampAreas.Add(registerStampArea);
			}
			data.RegisterStampAreas = data_registerStampAreas;

			List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_OtherStampArea> data_otherStampAreas = new List<RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_OtherStampArea>();
			for (int i = 0; i < context.Length("RecognizeAccountPage.Data.OtherStampAreas.Length"); i++) {
				RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_OtherStampArea otherStampArea = new RecognizeAccountPageResponse.RecognizeAccountPage_Data.RecognizeAccountPage_OtherStampArea();
				otherStampArea.Left = context.IntegerValue("RecognizeAccountPage.Data.OtherStampAreas["+ i +"].Left");
				otherStampArea.Top = context.IntegerValue("RecognizeAccountPage.Data.OtherStampAreas["+ i +"].Top");
				otherStampArea.Height = context.IntegerValue("RecognizeAccountPage.Data.OtherStampAreas["+ i +"].Height");
				otherStampArea.Width = context.IntegerValue("RecognizeAccountPage.Data.OtherStampAreas["+ i +"].Width");

				data_otherStampAreas.Add(otherStampArea);
			}
			data.OtherStampAreas = data_otherStampAreas;
			recognizeAccountPageResponse.Data = data;
        
			return recognizeAccountPageResponse;
        }
    }
}
