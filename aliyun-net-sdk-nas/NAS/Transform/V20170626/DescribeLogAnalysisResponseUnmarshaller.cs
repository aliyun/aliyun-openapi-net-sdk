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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeLogAnalysisResponseUnmarshaller
    {
        public static DescribeLogAnalysisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogAnalysisResponse describeLogAnalysisResponse = new DescribeLogAnalysisResponse();

			describeLogAnalysisResponse.HttpResponse = _ctx.HttpResponse;
			describeLogAnalysisResponse.TotalCount = _ctx.IntegerValue("DescribeLogAnalysis.TotalCount");
			describeLogAnalysisResponse.PageSize = _ctx.IntegerValue("DescribeLogAnalysis.PageSize");
			describeLogAnalysisResponse.RequestId = _ctx.StringValue("DescribeLogAnalysis.RequestId");
			describeLogAnalysisResponse.PageNumber = _ctx.IntegerValue("DescribeLogAnalysis.PageNumber");
			describeLogAnalysisResponse.Code = _ctx.StringValue("DescribeLogAnalysis.Code");

			List<DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis> describeLogAnalysisResponse_analyses = new List<DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis>();
			for (int i = 0; i < _ctx.Length("DescribeLogAnalysis.Analyses.Length"); i++) {
				DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis analysis = new DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis();
				analysis.MetaKey = _ctx.StringValue("DescribeLogAnalysis.Analyses["+ i +"].MetaKey");

				DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis.DescribeLogAnalysis_MetaValue metaValue = new DescribeLogAnalysisResponse.DescribeLogAnalysis_Analysis.DescribeLogAnalysis_MetaValue();
				metaValue.RoleArn = _ctx.StringValue("DescribeLogAnalysis.Analyses["+ i +"].MetaValue.RoleArn");
				metaValue.Region = _ctx.StringValue("DescribeLogAnalysis.Analyses["+ i +"].MetaValue.Region");
				metaValue.Logstore = _ctx.StringValue("DescribeLogAnalysis.Analyses["+ i +"].MetaValue.Logstore");
				metaValue.Project = _ctx.StringValue("DescribeLogAnalysis.Analyses["+ i +"].MetaValue.Project");
				analysis.MetaValue = metaValue;

				describeLogAnalysisResponse_analyses.Add(analysis);
			}
			describeLogAnalysisResponse.Analyses = describeLogAnalysisResponse_analyses;
        
			return describeLogAnalysisResponse;
        }
    }
}
