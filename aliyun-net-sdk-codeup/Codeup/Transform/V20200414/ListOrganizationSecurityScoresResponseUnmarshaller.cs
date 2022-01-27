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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class ListOrganizationSecurityScoresResponseUnmarshaller
    {
        public static ListOrganizationSecurityScoresResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrganizationSecurityScoresResponse listOrganizationSecurityScoresResponse = new ListOrganizationSecurityScoresResponse();

			listOrganizationSecurityScoresResponse.HttpResponse = _ctx.HttpResponse;
			listOrganizationSecurityScoresResponse.ErrorCode = _ctx.StringValue("ListOrganizationSecurityScores.ErrorCode");
			listOrganizationSecurityScoresResponse.ErrorMessage = _ctx.StringValue("ListOrganizationSecurityScores.ErrorMessage");
			listOrganizationSecurityScoresResponse.RequestId = _ctx.StringValue("ListOrganizationSecurityScores.RequestId");
			listOrganizationSecurityScoresResponse.Success = _ctx.BooleanValue("ListOrganizationSecurityScores.Success");

			List<ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem> listOrganizationSecurityScoresResponse_result = new List<ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListOrganizationSecurityScores.Result.Length"); i++) {
				ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem resultItem = new ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem();
				resultItem.Enable = _ctx.BooleanValue("ListOrganizationSecurityScores.Result["+ i +"].Enable");
				resultItem.Id = _ctx.LongValue("ListOrganizationSecurityScores.Result["+ i +"].Id");
				resultItem.OrganizationId = _ctx.StringValue("ListOrganizationSecurityScores.Result["+ i +"].OrganizationId");

				ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem.ListOrganizationSecurityScores_OrganizationSecurityScore organizationSecurityScore = new ListOrganizationSecurityScoresResponse.ListOrganizationSecurityScores_ResultItem.ListOrganizationSecurityScores_OrganizationSecurityScore();
				organizationSecurityScore.AuthorityControlScore = _ctx.IntegerValue("ListOrganizationSecurityScores.Result["+ i +"].OrganizationSecurityScore.AuthorityControlScore");
				organizationSecurityScore.CodeContentScore = _ctx.IntegerValue("ListOrganizationSecurityScores.Result["+ i +"].OrganizationSecurityScore.CodeContentScore");
				organizationSecurityScore.MemberBehaviorScore = _ctx.IntegerValue("ListOrganizationSecurityScores.Result["+ i +"].OrganizationSecurityScore.MemberBehaviorScore");
				organizationSecurityScore.Level = _ctx.StringValue("ListOrganizationSecurityScores.Result["+ i +"].OrganizationSecurityScore.Level");
				resultItem.OrganizationSecurityScore = organizationSecurityScore;

				listOrganizationSecurityScoresResponse_result.Add(resultItem);
			}
			listOrganizationSecurityScoresResponse.Result = listOrganizationSecurityScoresResponse_result;
        
			return listOrganizationSecurityScoresResponse;
        }
    }
}
