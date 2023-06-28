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
using Aliyun.Acs.nlp_automl.Model.V20191111;

namespace Aliyun.Acs.nlp_automl.Transform.V20191111
{
    public class FindUserReport4AlinlpResponseUnmarshaller
    {
        public static FindUserReport4AlinlpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FindUserReport4AlinlpResponse findUserReport4AlinlpResponse = new FindUserReport4AlinlpResponse();

			findUserReport4AlinlpResponse.HttpResponse = _ctx.HttpResponse;
			findUserReport4AlinlpResponse.RequestId = _ctx.StringValue("FindUserReport4Alinlp.RequestId");
			findUserReport4AlinlpResponse.Code = _ctx.StringValue("FindUserReport4Alinlp.Code");

			List<FindUserReport4AlinlpResponse.FindUserReport4Alinlp_Report> findUserReport4AlinlpResponse_data = new List<FindUserReport4AlinlpResponse.FindUserReport4Alinlp_Report>();
			for (int i = 0; i < _ctx.Length("FindUserReport4Alinlp.Data.Length"); i++) {
				FindUserReport4AlinlpResponse.FindUserReport4Alinlp_Report report = new FindUserReport4AlinlpResponse.FindUserReport4Alinlp_Report();
				report.TotalCount = _ctx.LongValue("FindUserReport4Alinlp.Data["+ i +"].TotalCount");
				report.SuccessCount = _ctx.LongValue("FindUserReport4Alinlp.Data["+ i +"].SuccessCount");
				report.FailCount = _ctx.LongValue("FindUserReport4Alinlp.Data["+ i +"].FailCount");
				report.QpsMax = _ctx.IntegerValue("FindUserReport4Alinlp.Data["+ i +"].QpsMax");
				report.RptTime = _ctx.StringValue("FindUserReport4Alinlp.Data["+ i +"].RptTime");

				findUserReport4AlinlpResponse_data.Add(report);
			}
			findUserReport4AlinlpResponse.Data = findUserReport4AlinlpResponse_data;
        
			return findUserReport4AlinlpResponse;
        }
    }
}
