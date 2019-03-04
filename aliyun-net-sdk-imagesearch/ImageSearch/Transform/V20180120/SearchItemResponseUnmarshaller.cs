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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ImageSearch.Model.V20180120;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.ImageSearch.Transform.V20180120
{
    public class SearchItemResponseUnmarshaller
    {
        public static SearchItemResponse Unmarshall(UnmarshallerContext context)
        {
			SearchItemResponse searchItemResponse = new SearchItemResponse();

			searchItemResponse.HttpResponse = context.HttpResponse;
			searchItemResponse.RequestId = context.StringValue("SearchItem.RequestId");
			searchItemResponse.Success = context.BooleanValue("SearchItem.Success");
			searchItemResponse.Message = context.StringValue("SearchItem.Message");
			searchItemResponse.Code = context.IntegerValue("SearchItem.Code");

			SearchItemResponse.SearchItem_Head head = new SearchItemResponse.SearchItem_Head();
			head.SearchTime = context.IntegerValue("SearchItem.Head.SearchTime");
			head.DocsFound = context.IntegerValue("SearchItem.Head.DocsFound");
			head.DocsReturn = context.IntegerValue("SearchItem.Head.DocsReturn");
			searchItemResponse.Head = head;

			SearchItemResponse.SearchItem_PicInfo picInfo = new SearchItemResponse.SearchItem_PicInfo();
			picInfo.Category = context.StringValue("SearchItem.PicInfo.Category");
			picInfo.Region = context.StringValue("SearchItem.PicInfo.Region");

			List<SearchItemResponse.SearchItem_PicInfo.SearchItem_Category> picInfo_allCategory = new List<SearchItemResponse.SearchItem_PicInfo.SearchItem_Category>();
			for (int i = 0; i < context.Length("SearchItem.PicInfo.AllCategory.Length"); i++) {
				SearchItemResponse.SearchItem_PicInfo.SearchItem_Category category = new SearchItemResponse.SearchItem_PicInfo.SearchItem_Category();
				category.Name = context.StringValue("SearchItem.PicInfo.AllCategory["+ i +"].Name");
				category.Id = context.StringValue("SearchItem.PicInfo.AllCategory["+ i +"].Id");

				picInfo_allCategory.Add(category);
			}
			picInfo.AllCategory = picInfo_allCategory;
			searchItemResponse.PicInfo = picInfo;

			List<SearchItemResponse.SearchItem_Auction> searchItemResponse_auctions = new List<SearchItemResponse.SearchItem_Auction>();
			for (int i = 0; i < context.Length("SearchItem.Auctions.Length"); i++) {
				SearchItemResponse.SearchItem_Auction auction = new SearchItemResponse.SearchItem_Auction();
				auction.CustContent = context.StringValue("SearchItem.Auctions["+ i +"].CustContent");
				auction.ItemId = context.StringValue("SearchItem.Auctions["+ i +"].ItemId");
				auction.SortExprValues = context.StringValue("SearchItem.Auctions["+ i +"].SortExprValues");
				auction.CatId = context.StringValue("SearchItem.Auctions["+ i +"].CatId");
				auction.PicName = context.StringValue("SearchItem.Auctions["+ i +"].PicName");

				searchItemResponse_auctions.Add(auction);
			}
			searchItemResponse.Auctions = searchItemResponse_auctions;
        
			return searchItemResponse;
        }
    }
}