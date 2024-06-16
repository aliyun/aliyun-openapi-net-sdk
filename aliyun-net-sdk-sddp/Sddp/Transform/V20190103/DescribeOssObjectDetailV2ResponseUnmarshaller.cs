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
    public class DescribeOssObjectDetailV2ResponseUnmarshaller
    {
        public static DescribeOssObjectDetailV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssObjectDetailV2Response describeOssObjectDetailV2Response = new DescribeOssObjectDetailV2Response();

			describeOssObjectDetailV2Response.HttpResponse = _ctx.HttpResponse;
			describeOssObjectDetailV2Response.RequestId = _ctx.StringValue("DescribeOssObjectDetailV2.RequestId");

			DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail ossObjectDetail = new DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail();
			ossObjectDetail.CategoryName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.CategoryName");
			ossObjectDetail.Name = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.Name");
			ossObjectDetail.BucketName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.BucketName");
			ossObjectDetail.RiskLevelName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RiskLevelName");
			ossObjectDetail.RegionId = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RegionId");

			List<DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule> ossObjectDetail_ruleList = new List<DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeOssObjectDetailV2.OssObjectDetail.RuleList.Length"); i++) {
				DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule rule = new DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule();
				rule.RiskLevelName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].RiskLevelName");
				rule.Category = _ctx.IntegerValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].Category");
				rule.CategoryName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].CategoryName");
				rule.RiskLevelId = _ctx.LongValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].RiskLevelId");
				rule.Count = _ctx.LongValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].Count");
				rule.RuleName = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].RuleName");

				List<string> rule_sampleList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].SampleList.Length"); j++) {
					rule_sampleList.Add(_ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].SampleList["+ j +"]"));
				}
				rule.SampleList = rule_sampleList;

				List<DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule.DescribeOssObjectDetailV2_ModelTagsItem> rule_modelTags = new List<DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule.DescribeOssObjectDetailV2_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].ModelTags.Length"); j++) {
					DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule.DescribeOssObjectDetailV2_ModelTagsItem modelTagsItem = new DescribeOssObjectDetailV2Response.DescribeOssObjectDetailV2_OssObjectDetail.DescribeOssObjectDetailV2_Rule.DescribeOssObjectDetailV2_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeOssObjectDetailV2.OssObjectDetail.RuleList["+ i +"].ModelTags["+ j +"].Name");

					rule_modelTags.Add(modelTagsItem);
				}
				rule.ModelTags = rule_modelTags;

				ossObjectDetail_ruleList.Add(rule);
			}
			ossObjectDetail.RuleList = ossObjectDetail_ruleList;
			describeOssObjectDetailV2Response.OssObjectDetail = ossObjectDetail;
        
			return describeOssObjectDetailV2Response;
        }
    }
}
