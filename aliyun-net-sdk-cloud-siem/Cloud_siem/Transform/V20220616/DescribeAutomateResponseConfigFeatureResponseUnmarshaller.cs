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
    public class DescribeAutomateResponseConfigFeatureResponseUnmarshaller
    {
        public static DescribeAutomateResponseConfigFeatureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutomateResponseConfigFeatureResponse describeAutomateResponseConfigFeatureResponse = new DescribeAutomateResponseConfigFeatureResponse();

			describeAutomateResponseConfigFeatureResponse.HttpResponse = _ctx.HttpResponse;
			describeAutomateResponseConfigFeatureResponse.Success = _ctx.BooleanValue("DescribeAutomateResponseConfigFeature.Success");
			describeAutomateResponseConfigFeatureResponse.Code = _ctx.IntegerValue("DescribeAutomateResponseConfigFeature.Code");
			describeAutomateResponseConfigFeatureResponse.Message = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Message");
			describeAutomateResponseConfigFeatureResponse.RequestId = _ctx.StringValue("DescribeAutomateResponseConfigFeature.RequestId");

			List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem> describeAutomateResponseConfigFeatureResponse_data = new List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAutomateResponseConfigFeature.Data.Length"); i++) {
				DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem dataItem = new DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem();
				dataItem.Feature = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].Feature");
				dataItem.DataType = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].DataType");

				List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_SupportOperator> dataItem_supportOperators = new List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_SupportOperator>();
				for (int j = 0; j < _ctx.Length("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators.Length"); j++) {
					DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_SupportOperator supportOperator = new DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_SupportOperator();
					supportOperator.HasRightValue = _ctx.BooleanValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].HasRightValue");
					supportOperator._Operator = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].Operator");
					supportOperator.OperatorName = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].OperatorName");
					supportOperator.OperatorDescCn = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].OperatorDescCn");
					supportOperator.OperatorDescEn = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].OperatorDescEn");
					supportOperator.SupportDataType = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].SupportDataType");
					supportOperator.Index = _ctx.IntegerValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].Index");

					List<string> supportOperator_supportTag = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].SupportTag.Length"); k++) {
						supportOperator_supportTag.Add(_ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].SupportOperators["+ j +"].SupportTag["+ k +"]"));
					}
					supportOperator.SupportTag = supportOperator_supportTag;

					dataItem_supportOperators.Add(supportOperator);
				}
				dataItem.SupportOperators = dataItem_supportOperators;

				List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_RightValueEnum> dataItem_rightValueEnums = new List<DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_RightValueEnum>();
				for (int j = 0; j < _ctx.Length("DescribeAutomateResponseConfigFeature.Data["+ i +"].RightValueEnums.Length"); j++) {
					DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_RightValueEnum rightValueEnum = new DescribeAutomateResponseConfigFeatureResponse.DescribeAutomateResponseConfigFeature_DataItem.DescribeAutomateResponseConfigFeature_RightValueEnum();
					rightValueEnum._Value = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].RightValueEnums["+ j +"].Value");
					rightValueEnum.ValueMds = _ctx.StringValue("DescribeAutomateResponseConfigFeature.Data["+ i +"].RightValueEnums["+ j +"].ValueMds");

					dataItem_rightValueEnums.Add(rightValueEnum);
				}
				dataItem.RightValueEnums = dataItem_rightValueEnums;

				describeAutomateResponseConfigFeatureResponse_data.Add(dataItem);
			}
			describeAutomateResponseConfigFeatureResponse.Data = describeAutomateResponseConfigFeatureResponse_data;
        
			return describeAutomateResponseConfigFeatureResponse;
        }
    }
}
