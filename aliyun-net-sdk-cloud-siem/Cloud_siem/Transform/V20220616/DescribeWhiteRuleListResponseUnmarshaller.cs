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
    public class DescribeWhiteRuleListResponseUnmarshaller
    {
        public static DescribeWhiteRuleListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWhiteRuleListResponse describeWhiteRuleListResponse = new DescribeWhiteRuleListResponse();

			describeWhiteRuleListResponse.HttpResponse = _ctx.HttpResponse;
			describeWhiteRuleListResponse.Success = _ctx.BooleanValue("DescribeWhiteRuleList.Success");
			describeWhiteRuleListResponse.Code = _ctx.IntegerValue("DescribeWhiteRuleList.Code");
			describeWhiteRuleListResponse.Message = _ctx.StringValue("DescribeWhiteRuleList.Message");
			describeWhiteRuleListResponse.RequestId = _ctx.StringValue("DescribeWhiteRuleList.RequestId");

			DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data data = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data();

			DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_PageInfo pageInfo = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeWhiteRuleList.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeWhiteRuleList.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeWhiteRuleList.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem> data_responseData = new List<DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeWhiteRuleList.Data.ResponseData.Length"); i++) {
				DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem responseDataItem = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.SubAliuid = _ctx.LongValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].SubAliuid");
				responseDataItem.AlertType = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.AlertTypeId = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].AlertTypeId");
				responseDataItem.AlertName = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].AlertName");
				responseDataItem.AlertNameId = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].AlertNameId");
				responseDataItem.Status = _ctx.IntegerValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Status");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].AlertUuid");

				DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression expression = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression();
				expression.Logic = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Logic");

				List<DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition> expression_conditions = new List<DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition>();
				for (int j = 0; j < _ctx.Length("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions.Length"); j++) {
					DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition condition = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition();
					condition.ItemId = _ctx.IntegerValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].ItemId");
					condition._Operator = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Operator");
					condition.IsNot = _ctx.BooleanValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].IsNot");

					DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition.DescribeWhiteRuleList_Left left = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition.DescribeWhiteRuleList_Left();
					left._Value = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Left.Value");
					left.IsVar = _ctx.BooleanValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Left.IsVar");
					left.Type = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Left.Type");
					left.Modifier = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Left.Modifier");
					left.ModifierParam = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Left.ModifierParam");
					condition.Left = left;

					DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition.DescribeWhiteRuleList_Right right = new DescribeWhiteRuleListResponse.DescribeWhiteRuleList_Data.DescribeWhiteRuleList_ResponseDataItem.DescribeWhiteRuleList_Expression.DescribeWhiteRuleList_Condition.DescribeWhiteRuleList_Right();
					right._Value = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Right.Value");
					right.IsVar = _ctx.BooleanValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Right.IsVar");
					right.Type = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Right.Type");
					right.Modifier = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Right.Modifier");
					right.ModifierParam = _ctx.StringValue("DescribeWhiteRuleList.Data.ResponseData["+ i +"].Expression.Conditions["+ j +"].Right.ModifierParam");
					condition.Right = right;

					expression_conditions.Add(condition);
				}
				expression.Conditions = expression_conditions;
				responseDataItem.Expression = expression;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeWhiteRuleListResponse.Data = data;
        
			return describeWhiteRuleListResponse;
        }
    }
}
