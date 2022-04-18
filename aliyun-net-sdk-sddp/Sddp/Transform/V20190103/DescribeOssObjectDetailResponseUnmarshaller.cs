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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeOssObjectDetailResponseUnmarshaller
    {
        public static DescribeOssObjectDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssObjectDetailResponse describeOssObjectDetailResponse = new DescribeOssObjectDetailResponse();

			describeOssObjectDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeOssObjectDetailResponse.RequestId = _ctx.StringValue("DescribeOssObjectDetail.RequestId");

			DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail ossObjectDetail = new DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail();
			ossObjectDetail.CategoryName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.CategoryName");
			ossObjectDetail.Name = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.Name");
			ossObjectDetail.BucketName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.BucketName");
			ossObjectDetail.RiskLevelName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RiskLevelName");
			ossObjectDetail.RegionId = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RegionId");

			List<DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule> ossObjectDetail_ruleList = new List<DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeOssObjectDetail.OssObjectDetail.RuleList.Length"); i++) {
				DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule rule = new DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule();
				rule.RiskLevelName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].RiskLevelName");
				rule.Category = _ctx.IntegerValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].Category");
				rule.CategoryName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].CategoryName");
				rule.RiskLevelId = _ctx.LongValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].RiskLevelId");
				rule.Count = _ctx.LongValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].Count");
				rule.RuleName = _ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].RuleName");

				List<string> rule_sampleList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].SampleList.Length"); j++) {
					rule_sampleList.Add(_ctx.StringValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].SampleList["+ j +"]"));
				}
				rule.SampleList = rule_sampleList;

				ossObjectDetail_ruleList.Add(rule);
			}
			ossObjectDetail.RuleList = ossObjectDetail_ruleList;
			describeOssObjectDetailResponse.OssObjectDetail = ossObjectDetail;
        
			return describeOssObjectDetailResponse;
        }
    }
}
