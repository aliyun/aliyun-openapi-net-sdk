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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeCharsetResponseUnmarshaller
    {
        public static DescribeCharsetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCharsetResponse describeCharsetResponse = new DescribeCharsetResponse();

			describeCharsetResponse.HttpResponse = _ctx.HttpResponse;
			describeCharsetResponse.RequestId = _ctx.StringValue("DescribeCharset.RequestId");

			List<DescribeCharsetResponse.DescribeCharset_CharsetItem> describeCharsetResponse_charset = new List<DescribeCharsetResponse.DescribeCharset_CharsetItem>();
			for (int i = 0; i < _ctx.Length("DescribeCharset.Charset.Length"); i++) {
				DescribeCharsetResponse.DescribeCharset_CharsetItem charsetItem = new DescribeCharsetResponse.DescribeCharset_CharsetItem();
				charsetItem.Charset = _ctx.StringValue("DescribeCharset.Charset["+ i +"].Charset");

				List<string> charsetItem_collations = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCharset.Charset["+ i +"].Collations.Length"); j++) {
					charsetItem_collations.Add(_ctx.StringValue("DescribeCharset.Charset["+ i +"].Collations["+ j +"]"));
				}
				charsetItem.Collations = charsetItem_collations;

				describeCharsetResponse_charset.Add(charsetItem);
			}
			describeCharsetResponse.Charset = describeCharsetResponse_charset;
        
			return describeCharsetResponse;
        }
    }
}
