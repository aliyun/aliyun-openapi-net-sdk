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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeCacheAnalysisReportResponseUnmarshaller
    {
        public static DescribeCacheAnalysisReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCacheAnalysisReportResponse describeCacheAnalysisReportResponse = new DescribeCacheAnalysisReportResponse();

			describeCacheAnalysisReportResponse.HttpResponse = _ctx.HttpResponse;
			describeCacheAnalysisReportResponse.RequestId = _ctx.StringValue("DescribeCacheAnalysisReport.RequestId");
			describeCacheAnalysisReportResponse.TotalRecordCount = _ctx.IntegerValue("DescribeCacheAnalysisReport.TotalRecordCount");
			describeCacheAnalysisReportResponse.PageSize = _ctx.IntegerValue("DescribeCacheAnalysisReport.PageSize");
			describeCacheAnalysisReportResponse.PageNumber = _ctx.IntegerValue("DescribeCacheAnalysisReport.PageNumber");
			describeCacheAnalysisReportResponse.PageRecordCount = _ctx.IntegerValue("DescribeCacheAnalysisReport.PageRecordCount");

			List<Dictionary<string, string>> describeCacheAnalysisReportResponse_hotKeys = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("DescribeCacheAnalysisReport.HotKeys.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "DescribeCacheAnalysisReport.HotKeys["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					describeCacheAnalysisReportResponse_hotKeys.Add(tmp);
				}
			}
			describeCacheAnalysisReportResponse.HotKeys = describeCacheAnalysisReportResponse_hotKeys;

			List<Dictionary<string, string>> describeCacheAnalysisReportResponse_bigKeys = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("DescribeCacheAnalysisReport.BigKeys.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "DescribeCacheAnalysisReport.BigKeys["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					describeCacheAnalysisReportResponse_bigKeys.Add(tmp);
				}
			}
			describeCacheAnalysisReportResponse.BigKeys = describeCacheAnalysisReportResponse_bigKeys;
        
			return describeCacheAnalysisReportResponse;
        }
    }
}
