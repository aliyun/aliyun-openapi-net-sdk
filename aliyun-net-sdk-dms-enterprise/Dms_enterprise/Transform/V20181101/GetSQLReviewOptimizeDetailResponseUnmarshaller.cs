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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetSQLReviewOptimizeDetailResponseUnmarshaller
    {
        public static GetSQLReviewOptimizeDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSQLReviewOptimizeDetailResponse getSQLReviewOptimizeDetailResponse = new GetSQLReviewOptimizeDetailResponse();

			getSQLReviewOptimizeDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSQLReviewOptimizeDetailResponse.RequestId = _ctx.StringValue("GetSQLReviewOptimizeDetail.RequestId");
			getSQLReviewOptimizeDetailResponse.ErrorCode = _ctx.StringValue("GetSQLReviewOptimizeDetail.ErrorCode");
			getSQLReviewOptimizeDetailResponse.ErrorMessage = _ctx.StringValue("GetSQLReviewOptimizeDetail.ErrorMessage");
			getSQLReviewOptimizeDetailResponse.Success = _ctx.BooleanValue("GetSQLReviewOptimizeDetail.Success");

			GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail optimizeDetail = new GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail();
			optimizeDetail.QueryKey = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QueryKey");
			optimizeDetail.InstanceId = _ctx.IntegerValue("GetSQLReviewOptimizeDetail.OptimizeDetail.InstanceId");
			optimizeDetail.DbId = _ctx.IntegerValue("GetSQLReviewOptimizeDetail.OptimizeDetail.DbId");
			optimizeDetail.SqlType = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.SqlType");

			GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult qualityResult = new GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult();
			qualityResult.ErrorMessage = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.ErrorMessage");
			qualityResult.OccurError = _ctx.BooleanValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.OccurError");

			List<GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem> qualityResult_results = new List<GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem>();
			for (int i = 0; i < _ctx.Length("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results.Length"); i++) {
				GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem resultsItem = new GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem();
				resultsItem.RuleName = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].RuleName");
				resultsItem.Feedback = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Feedback");
				resultsItem.Comments = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Comments");
				resultsItem.RuleType = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].RuleType");

				List<string> resultsItem_messages = new List<string>();
				for (int j = 0; j < _ctx.Length("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Messages.Length"); j++) {
					resultsItem_messages.Add(_ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Messages["+ j +"]"));
				}
				resultsItem.Messages = resultsItem_messages;

				List<GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem.GetSQLReviewOptimizeDetail_ScriptsItem> resultsItem_scripts = new List<GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem.GetSQLReviewOptimizeDetail_ScriptsItem>();
				for (int j = 0; j < _ctx.Length("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Scripts.Length"); j++) {
					GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem.GetSQLReviewOptimizeDetail_ScriptsItem scriptsItem = new GetSQLReviewOptimizeDetailResponse.GetSQLReviewOptimizeDetail_OptimizeDetail.GetSQLReviewOptimizeDetail_QualityResult.GetSQLReviewOptimizeDetail_ResultsItem.GetSQLReviewOptimizeDetail_ScriptsItem();
					scriptsItem.OpType = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Scripts["+ j +"].OpType");
					scriptsItem.Content = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Scripts["+ j +"].Content");
					scriptsItem.TableName = _ctx.StringValue("GetSQLReviewOptimizeDetail.OptimizeDetail.QualityResult.Results["+ i +"].Scripts["+ j +"].TableName");

					resultsItem_scripts.Add(scriptsItem);
				}
				resultsItem.Scripts = resultsItem_scripts;

				qualityResult_results.Add(resultsItem);
			}
			qualityResult.Results = qualityResult_results;
			optimizeDetail.QualityResult = qualityResult;
			getSQLReviewOptimizeDetailResponse.OptimizeDetail = optimizeDetail;
        
			return getSQLReviewOptimizeDetailResponse;
        }
    }
}
