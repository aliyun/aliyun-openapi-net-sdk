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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ShowQuickAnalysisResponseUnmarshaller
    {
        public static ShowQuickAnalysisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ShowQuickAnalysisResponse showQuickAnalysisResponse = new ShowQuickAnalysisResponse();

			showQuickAnalysisResponse.HttpResponse = _ctx.HttpResponse;
			showQuickAnalysisResponse.RequestId = _ctx.StringValue("ShowQuickAnalysis.RequestId");

			ShowQuickAnalysisResponse.ShowQuickAnalysis_Data data = new ShowQuickAnalysisResponse.ShowQuickAnalysis_Data();

			List<string> data_indexList = new List<string>();
			for (int i = 0; i < _ctx.Length("ShowQuickAnalysis.Data.IndexList.Length"); i++) {
				data_indexList.Add(_ctx.StringValue("ShowQuickAnalysis.Data.IndexList["+ i +"]"));
			}
			data.IndexList = data_indexList;
			showQuickAnalysisResponse.Data = data;
        
			return showQuickAnalysisResponse;
        }
    }
}
