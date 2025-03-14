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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class VerifyPythonFileResponseUnmarshaller
    {
        public static VerifyPythonFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyPythonFileResponse verifyPythonFileResponse = new VerifyPythonFileResponse();

			verifyPythonFileResponse.HttpResponse = _ctx.HttpResponse;
			verifyPythonFileResponse.RequestId = _ctx.StringValue("VerifyPythonFile.RequestId");

			List<VerifyPythonFileResponse.VerifyPythonFile_SyntaxItem> verifyPythonFileResponse_syntax = new List<VerifyPythonFileResponse.VerifyPythonFile_SyntaxItem>();
			for (int i = 0; i < _ctx.Length("VerifyPythonFile.Syntax.Length"); i++) {
				VerifyPythonFileResponse.VerifyPythonFile_SyntaxItem syntaxItem = new VerifyPythonFileResponse.VerifyPythonFile_SyntaxItem();
				syntaxItem.StartLineNumber = _ctx.IntegerValue("VerifyPythonFile.Syntax["+ i +"].StartLineNumber");
				syntaxItem.StartColumn = _ctx.IntegerValue("VerifyPythonFile.Syntax["+ i +"].StartColumn");
				syntaxItem.EndLineNumber = _ctx.IntegerValue("VerifyPythonFile.Syntax["+ i +"].EndLineNumber");
				syntaxItem.EndColumn = _ctx.IntegerValue("VerifyPythonFile.Syntax["+ i +"].EndColumn");
				syntaxItem.Message = _ctx.StringValue("VerifyPythonFile.Syntax["+ i +"].Message");
				syntaxItem.Severity = _ctx.IntegerValue("VerifyPythonFile.Syntax["+ i +"].Severity");

				verifyPythonFileResponse_syntax.Add(syntaxItem);
			}
			verifyPythonFileResponse.Syntax = verifyPythonFileResponse_syntax;
        
			return verifyPythonFileResponse;
        }
    }
}
