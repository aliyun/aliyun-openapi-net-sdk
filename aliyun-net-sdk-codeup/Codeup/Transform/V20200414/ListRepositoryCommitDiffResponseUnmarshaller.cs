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
    public class ListRepositoryCommitDiffResponseUnmarshaller
    {
        public static ListRepositoryCommitDiffResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryCommitDiffResponse listRepositoryCommitDiffResponse = new ListRepositoryCommitDiffResponse();

			listRepositoryCommitDiffResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryCommitDiffResponse.ErrorCode = _ctx.StringValue("ListRepositoryCommitDiff.ErrorCode");
			listRepositoryCommitDiffResponse.ErrorMessage = _ctx.StringValue("ListRepositoryCommitDiff.ErrorMessage");
			listRepositoryCommitDiffResponse.RequestId = _ctx.StringValue("ListRepositoryCommitDiff.RequestId");
			listRepositoryCommitDiffResponse.Success = _ctx.BooleanValue("ListRepositoryCommitDiff.Success");

			List<ListRepositoryCommitDiffResponse.ListRepositoryCommitDiff_ResultItem> listRepositoryCommitDiffResponse_result = new List<ListRepositoryCommitDiffResponse.ListRepositoryCommitDiff_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryCommitDiff.Result.Length"); i++) {
				ListRepositoryCommitDiffResponse.ListRepositoryCommitDiff_ResultItem resultItem = new ListRepositoryCommitDiffResponse.ListRepositoryCommitDiff_ResultItem();
				resultItem.AMode = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].AMode");
				resultItem.BMode = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].BMode");
				resultItem.DeletedFile = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].DeletedFile");
				resultItem.Diff = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].Diff");
				resultItem.IsBinary = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].IsBinary");
				resultItem.IsNewLfs = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].IsNewLfs");
				resultItem.IsOldLfs = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].IsOldLfs");
				resultItem.NewFile = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].NewFile");
				resultItem.NewId = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].NewId");
				resultItem.NewPath = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].NewPath");
				resultItem.OldId = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].OldId");
				resultItem.OldPath = _ctx.StringValue("ListRepositoryCommitDiff.Result["+ i +"].OldPath");
				resultItem.RenamedFile = _ctx.BooleanValue("ListRepositoryCommitDiff.Result["+ i +"].RenamedFile");

				listRepositoryCommitDiffResponse_result.Add(resultItem);
			}
			listRepositoryCommitDiffResponse.Result = listRepositoryCommitDiffResponse_result;
        
			return listRepositoryCommitDiffResponse;
        }
    }
}
