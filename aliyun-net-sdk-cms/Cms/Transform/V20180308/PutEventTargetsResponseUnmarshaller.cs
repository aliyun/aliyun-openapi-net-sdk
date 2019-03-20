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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class PutEventTargetsResponseUnmarshaller
    {
        public static PutEventTargetsResponse Unmarshall(UnmarshallerContext context)
        {
			PutEventTargetsResponse putEventTargetsResponse = new PutEventTargetsResponse();

			putEventTargetsResponse.HttpResponse = context.HttpResponse;
			putEventTargetsResponse.Success = context.BooleanValue("PutEventTargets.Success");
			putEventTargetsResponse.Code = context.StringValue("PutEventTargets.Code");
			putEventTargetsResponse.Message = context.StringValue("PutEventTargets.Message");
			putEventTargetsResponse.RequestId = context.StringValue("PutEventTargets.RequestId");
			putEventTargetsResponse.ParameterCount = context.StringValue("PutEventTargets.ParameterCount");
			putEventTargetsResponse.FailedParameterCount = context.StringValue("PutEventTargets.FailedParameterCount");

			List<PutEventTargetsResponse.PutEventTargets_ContactParameter> putEventTargetsResponse_contactParameters = new List<PutEventTargetsResponse.PutEventTargets_ContactParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.ContactParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_ContactParameter contactParameter = new PutEventTargetsResponse.PutEventTargets_ContactParameter();
				contactParameter.Id = context.IntegerValue("PutEventTargets.ContactParameters["+ i +"].Id");
				contactParameter.ContactGroupName = context.StringValue("PutEventTargets.ContactParameters["+ i +"].ContactGroupName");
				contactParameter.Level = context.StringValue("PutEventTargets.ContactParameters["+ i +"].Level");

				putEventTargetsResponse_contactParameters.Add(contactParameter);
			}
			putEventTargetsResponse.ContactParameters = putEventTargetsResponse_contactParameters;

			List<PutEventTargetsResponse.PutEventTargets_MnsParameter> putEventTargetsResponse_mnsParameters = new List<PutEventTargetsResponse.PutEventTargets_MnsParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.MnsParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_MnsParameter mnsParameter = new PutEventTargetsResponse.PutEventTargets_MnsParameter();
				mnsParameter.Id = context.IntegerValue("PutEventTargets.MnsParameters["+ i +"].Id");
				mnsParameter.Region = context.StringValue("PutEventTargets.MnsParameters["+ i +"].Region");
				mnsParameter.Queue = context.StringValue("PutEventTargets.MnsParameters["+ i +"].Queue");

				putEventTargetsResponse_mnsParameters.Add(mnsParameter);
			}
			putEventTargetsResponse.MnsParameters = putEventTargetsResponse_mnsParameters;

			List<PutEventTargetsResponse.PutEventTargets_FcParameter> putEventTargetsResponse_fcParameters = new List<PutEventTargetsResponse.PutEventTargets_FcParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.FcParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_FcParameter fcParameter = new PutEventTargetsResponse.PutEventTargets_FcParameter();
				fcParameter.Id = context.IntegerValue("PutEventTargets.FcParameters["+ i +"].Id");
				fcParameter.Region = context.StringValue("PutEventTargets.FcParameters["+ i +"].Region");
				fcParameter.ServiceName = context.StringValue("PutEventTargets.FcParameters["+ i +"].ServiceName");
				fcParameter.FunctionName = context.StringValue("PutEventTargets.FcParameters["+ i +"].FunctionName");

				putEventTargetsResponse_fcParameters.Add(fcParameter);
			}
			putEventTargetsResponse.FcParameters = putEventTargetsResponse_fcParameters;

			List<PutEventTargetsResponse.PutEventTargets_ContactParameter> putEventTargetsResponse_failedContactParameters = new List<PutEventTargetsResponse.PutEventTargets_ContactParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.FailedContactParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_ContactParameter contactParameter = new PutEventTargetsResponse.PutEventTargets_ContactParameter();
				contactParameter.Id = context.IntegerValue("PutEventTargets.FailedContactParameters["+ i +"].Id");
				contactParameter.ContactGroupName = context.StringValue("PutEventTargets.FailedContactParameters["+ i +"].ContactGroupName");
				contactParameter.Level = context.StringValue("PutEventTargets.FailedContactParameters["+ i +"].Level");

				putEventTargetsResponse_failedContactParameters.Add(contactParameter);
			}
			putEventTargetsResponse.FailedContactParameters = putEventTargetsResponse_failedContactParameters;

			List<PutEventTargetsResponse.PutEventTargets_MnsParameter> putEventTargetsResponse_failedMnsParameters = new List<PutEventTargetsResponse.PutEventTargets_MnsParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.FailedMnsParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_MnsParameter mnsParameter = new PutEventTargetsResponse.PutEventTargets_MnsParameter();
				mnsParameter.Id = context.IntegerValue("PutEventTargets.FailedMnsParameters["+ i +"].Id");
				mnsParameter.Region = context.StringValue("PutEventTargets.FailedMnsParameters["+ i +"].Region");
				mnsParameter.Queue = context.StringValue("PutEventTargets.FailedMnsParameters["+ i +"].Queue");

				putEventTargetsResponse_failedMnsParameters.Add(mnsParameter);
			}
			putEventTargetsResponse.FailedMnsParameters = putEventTargetsResponse_failedMnsParameters;

			List<PutEventTargetsResponse.PutEventTargets_FcParameter> putEventTargetsResponse_failedFcParameters = new List<PutEventTargetsResponse.PutEventTargets_FcParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.FailedFcParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_FcParameter fcParameter = new PutEventTargetsResponse.PutEventTargets_FcParameter();
				fcParameter.Id = context.IntegerValue("PutEventTargets.FailedFcParameters["+ i +"].Id");
				fcParameter.Region = context.StringValue("PutEventTargets.FailedFcParameters["+ i +"].Region");
				fcParameter.ServiceName = context.StringValue("PutEventTargets.FailedFcParameters["+ i +"].ServiceName");
				fcParameter.FunctionName = context.StringValue("PutEventTargets.FailedFcParameters["+ i +"].FunctionName");

				putEventTargetsResponse_failedFcParameters.Add(fcParameter);
			}
			putEventTargetsResponse.FailedFcParameters = putEventTargetsResponse_failedFcParameters;

			List<PutEventTargetsResponse.PutEventTargets_FailedSlsParameter> putEventTargetsResponse_failedSlsParameters = new List<PutEventTargetsResponse.PutEventTargets_FailedSlsParameter>();
			for (int i = 0; i < context.Length("PutEventTargets.FailedSlsParameters.Length"); i++) {
				PutEventTargetsResponse.PutEventTargets_FailedSlsParameter failedSlsParameter = new PutEventTargetsResponse.PutEventTargets_FailedSlsParameter();
				failedSlsParameter.Id = context.StringValue("PutEventTargets.FailedSlsParameters["+ i +"].Id");
				failedSlsParameter.Region = context.StringValue("PutEventTargets.FailedSlsParameters["+ i +"].Region");
				failedSlsParameter.Project = context.StringValue("PutEventTargets.FailedSlsParameters["+ i +"].Project");
				failedSlsParameter.LogStore = context.StringValue("PutEventTargets.FailedSlsParameters["+ i +"].LogStore");

				putEventTargetsResponse_failedSlsParameters.Add(failedSlsParameter);
			}
			putEventTargetsResponse.FailedSlsParameters = putEventTargetsResponse_failedSlsParameters;
        
			return putEventTargetsResponse;
        }
    }
}
