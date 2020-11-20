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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetTitleDiagnoseResponseUnmarshaller
    {
        public static GetTitleDiagnoseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTitleDiagnoseResponse getTitleDiagnoseResponse = new GetTitleDiagnoseResponse();

			getTitleDiagnoseResponse.HttpResponse = _ctx.HttpResponse;
			getTitleDiagnoseResponse.RequestId = _ctx.StringValue("GetTitleDiagnose.RequestId");
			getTitleDiagnoseResponse.Code = _ctx.IntegerValue("GetTitleDiagnose.Code");
			getTitleDiagnoseResponse.Message = _ctx.StringValue("GetTitleDiagnose.Message");

			GetTitleDiagnoseResponse.GetTitleDiagnose_Data data = new GetTitleDiagnoseResponse.GetTitleDiagnose_Data();
			data.ContainCoreClasses = _ctx.StringValue("GetTitleDiagnose.Data.ContainCoreClasses");
			data.OverLengthLimit = _ctx.StringValue("GetTitleDiagnose.Data.OverLengthLimit");
			data.WordSpelledCorrectError = _ctx.StringValue("GetTitleDiagnose.Data.WordSpelledCorrectError");
			data.AllUppercaseWords = _ctx.StringValue("GetTitleDiagnose.Data.AllUppercaseWords");
			data.NoFirstUppercaseList = _ctx.StringValue("GetTitleDiagnose.Data.NoFirstUppercaseList");
			data.DuplicateWords = _ctx.StringValue("GetTitleDiagnose.Data.DuplicateWords");
			data.DisableWords = _ctx.StringValue("GetTitleDiagnose.Data.DisableWords");
			data.WordCount = _ctx.StringValue("GetTitleDiagnose.Data.WordCount");
			data.TotalScore = _ctx.StringValue("GetTitleDiagnose.Data.TotalScore");
			data.LanguageQualityScore = _ctx.StringValue("GetTitleDiagnose.Data.LanguageQualityScore");
			getTitleDiagnoseResponse.Data = data;
        
			return getTitleDiagnoseResponse;
        }
    }
}
