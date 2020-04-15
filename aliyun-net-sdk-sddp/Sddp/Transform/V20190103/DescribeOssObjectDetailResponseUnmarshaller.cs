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
        public static DescribeOssObjectDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssObjectDetailResponse describeOssObjectDetailResponse = new DescribeOssObjectDetailResponse();

			describeOssObjectDetailResponse.HttpResponse = context.HttpResponse;
			describeOssObjectDetailResponse.RequestId = context.StringValue("DescribeOssObjectDetail.RequestId");

			DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail ossObjectDetail = new DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail();
			ossObjectDetail.Name = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.Name");
			ossObjectDetail.RegionId = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.RegionId");
			ossObjectDetail.RiskLevelName = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.RiskLevelName");
			ossObjectDetail.BucketName = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.BucketName");
			ossObjectDetail.CategoryName = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.CategoryName");

			List<DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule> ossObjectDetail_ruleList = new List<DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule>();
			for (int i = 0; i < context.Length("DescribeOssObjectDetail.OssObjectDetail.RuleList.Length"); i++) {
				DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule rule = new DescribeOssObjectDetailResponse.DescribeOssObjectDetail_OssObjectDetail.DescribeOssObjectDetail_Rule();
				rule.RuleName = context.StringValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].RuleName");
				rule.Count = context.LongValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].Count");
				rule.Category = context.IntegerValue("DescribeOssObjectDetail.OssObjectDetail.RuleList["+ i +"].Category");

				ossObjectDetail_ruleList.Add(rule);
			}
			ossObjectDetail.RuleList = ossObjectDetail_ruleList;
			describeOssObjectDetailResponse.OssObjectDetail = ossObjectDetail;
        
			return describeOssObjectDetailResponse;
        }
    }
}
