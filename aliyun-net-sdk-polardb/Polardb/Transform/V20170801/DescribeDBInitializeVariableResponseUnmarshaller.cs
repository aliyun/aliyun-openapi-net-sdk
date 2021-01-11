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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBInitializeVariableResponseUnmarshaller
    {
        public static DescribeDBInitializeVariableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInitializeVariableResponse describeDBInitializeVariableResponse = new DescribeDBInitializeVariableResponse();

			describeDBInitializeVariableResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInitializeVariableResponse.RequestId = _ctx.StringValue("DescribeDBInitializeVariable.RequestId");
			describeDBInitializeVariableResponse.DBType = _ctx.StringValue("DescribeDBInitializeVariable.DBType");
			describeDBInitializeVariableResponse.DBVersion = _ctx.StringValue("DescribeDBInitializeVariable.DBVersion");

			List<DescribeDBInitializeVariableResponse.DescribeDBInitializeVariable_Variable> describeDBInitializeVariableResponse_variables = new List<DescribeDBInitializeVariableResponse.DescribeDBInitializeVariable_Variable>();
			for (int i = 0; i < _ctx.Length("DescribeDBInitializeVariable.Variables.Length"); i++) {
				DescribeDBInitializeVariableResponse.DescribeDBInitializeVariable_Variable variable = new DescribeDBInitializeVariableResponse.DescribeDBInitializeVariable_Variable();
				variable.Charset = _ctx.StringValue("DescribeDBInitializeVariable.Variables["+ i +"].Charset");
				variable.Collate = _ctx.StringValue("DescribeDBInitializeVariable.Variables["+ i +"].Collate");
				variable.Ctype = _ctx.StringValue("DescribeDBInitializeVariable.Variables["+ i +"].Ctype");

				describeDBInitializeVariableResponse_variables.Add(variable);
			}
			describeDBInitializeVariableResponse.Variables = describeDBInitializeVariableResponse_variables;
        
			return describeDBInitializeVariableResponse;
        }
    }
}
